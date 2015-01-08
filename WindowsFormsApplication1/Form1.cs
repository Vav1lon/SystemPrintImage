using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using S4;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using SPimg;
using SPimg.Model;


namespace SPImg
{
    public partial class fMain : Form
    {
        static S4.ITS4App SearcheAPI = new S4.TS4AppClass();
        String[] itemArray;
        String[] itemArray2;
        ListBox ListFind = new ListBox();
        PrintDialog prSetting = null;
        List<String> ListNotFinditems = new List<String>();

        public fMain()
        {
            InitializeComponent();
            SearcheAPI.Login();
        }

        //Сохадет дерево из верхнего уровня
        private void CreateTree(String NameItem, Boolean FirstLine)
        {
            TreeNode rootNode = new TreeNode(NameItem);
            treeView1.Nodes.Add(rootNode);

            int ItemId, c;
            double a;
            this.sbProgressBar.Value = 0;
            ItemId = SearcheAPI.GetArtID_ByDesignation(NameItem);
            SearcheAPI.OpenArticle(ItemId);
            SearcheAPI.OpenArticleStructure(ItemId);
            if (SearcheAPI.asCount() > 0)
            {
                itemArray = new String[SearcheAPI.asCount()];
                SearcheAPI.asFirst();
                a = 100 / SearcheAPI.asCount();
                for (c = 0; c < SearcheAPI.asCount(); c++)
                {
                    if (SearcheAPI.asGetArtKind() == 1 | SearcheAPI.asGetArtKind() == 4 | SearcheAPI.asGetArtKind() == 3)
                    {
                        this.sbText.Text = SearcheAPI.asGetArtDesignation();
                        this.Update();
                        if (SearcheAPI.asGetArtDesignation().IndexOf("ЭТ") != -1)
                        {
                            itemArray[c] = SearcheAPI.asGetArtDesignation();
                        }
                    }
                    SearcheAPI.asNext();
                    this.sbProgressBar.Value = this.sbProgressBar.Value + Convert.ToInt32(a);
                }
                Fill(rootNode, itemArray, 0);
            }
            SearcheAPI.CloseArticleStructure();
            SearcheAPI.CloseArticle();
            this.sbProgressBar.Value = 100;
        }

        //Вспомогательная функция для создания дерева
        private void Fill(TreeNode parentNode, Array childDataElements, int level)
        {
            int ItemIdadd, c;
            Double a;
            if (parentNode.Text.IndexOf("СБ") == -1)
            {
                foreach (object item in childDataElements)
                {
                    if (item != null)
                    {
                        this.sbProgressBar.Value = 0;
                        TreeNode newNode = new TreeNode(item.ToString());
                        parentNode.Nodes.Add(newNode);
                        ItemIdadd = SearcheAPI.GetArtID_ByDesignation(Convert.ToString(item));
                        SearcheAPI.OpenArticle(ItemIdadd);
                        SearcheAPI.OpenArticleStructure(ItemIdadd);
                        if (SearcheAPI.asCount() > 1)
                        {
                            itemArray2 = new String[SearcheAPI.asCount()];
                            SearcheAPI.asFirst();
                            a = 100 / SearcheAPI.asCount();
                            for (c = 0; c < SearcheAPI.asCount(); c++)
                            {
                                if (SearcheAPI.asGetArtKind() == 1 | SearcheAPI.asGetArtKind() == 4 | SearcheAPI.asGetArtKind() == 3)
                                {
                                    this.sbText.Text = SearcheAPI.asGetArtDesignation();
                                    if (SearcheAPI.asGetArtDesignation() != null && SearcheAPI.asGetArtDesignation().IndexOf("ЭТ") != -1)
                                    {
                                        itemArray2[c] = SearcheAPI.asGetArtDesignation();
                                    }
                                }
                                SearcheAPI.asNext();
                                this.sbProgressBar.Value = this.sbProgressBar.Value + Convert.ToInt32(a);
                            }

                            Fill(newNode, itemArray2, level + 1);
                        }
                        SearcheAPI.CloseArticleStructure();
                        SearcheAPI.CloseArticle();
                        this.sbProgressBar.Value = 100;
                    }
                }
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.forArchiveProgsTableAdapter.Fill(this.dataSet1.forArchiveProgs);
        }

        //Помечает все дерево
        private void ChekTree_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null) { getChekFullTree(this.treeView1.SelectedNode); }
        }

        //Исполняемый код для пометки дерева
        private void getChekFullTree(TreeNode treeNode)
        {
            treeNode.ExpandAll();
            if (treeNode.Checked != true) { treeNode.Checked = true; }
            if (treeNode.Nodes.Count != 0)
            {
                foreach (TreeNode nod in treeNode.Nodes)
                {
                    if (nod.Checked == false) { nod.Checked = true; }
                    if (nod.Nodes.Count != 0) { getChekFullTree(nod); }
                }
            }
        }

        //Исполняемый код для снятия отметок
        private void getNotChekFullTree(TreeNode treeNode)
        {
            if (treeNode.Checked == true) { treeNode.Checked = false; }
            if (treeNode.Nodes.Count != 0)
            {
                foreach (TreeNode nod in treeNode.Nodes)
                {
                    if (nod.Checked == true) { nod.Checked = false; }
                    if (nod.Nodes.Count != 0) { getNotChekFullTree(nod); }
                }
            }
        }

        //Снять отметки с дерева
        private void notChekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null) { getNotChekFullTree(this.treeView1.SelectedNode); }
        }

        private void toListFind(TreeNode treeNode)
        {
            if (treeNode.Checked == true) { ListFind.Items.Add(treeNode.Text); }
            if (treeNode.Nodes.Count != 0)
            {
                foreach (TreeNode nod in treeNode.Nodes)
                {
                    if (nod.Checked == true) { ListFind.Items.Add(nod.Text); }
                    if (nod.Nodes.Count != 0) { toListFind(nod); }
                }
            }
        }

        private void findAddItems(String path, String nameFiles)
        {
            DirectoryInfo dir = new DirectoryInfo(@"\\fs63\UserData\Подготовка производства\Чертежи\" + path);
            DirectoryInfo[] directories = dir.GetDirectories();
            foreach (DirectoryInfo dr in directories)
            {
                if (dr.Name.IndexOf(nameFiles.Substring(0, 7)) != -1)
                {
                    DirectoryInfo dirFiles = new DirectoryInfo(dir + "\\" + dr);
                    FileInfo[] files = dirFiles.GetFiles();
                    foreach (FileInfo fls in files)
                    {
                        if (fls.Name.IndexOf(nameFiles) != -1)
                        {
                            detectFormat(dir + "\\" + dr.Name + "\\" + fls.Name);
                        }
                        else
                        {
                            //NotFindItems(nameFiles);
                        }
                    }
                }
            }
        }

        IEnumerable<string> Find(string param)
        {
            foreach (var file in Directory.GetFiles("rewterwy"))
            {
                yield return file;
            }

            /*
            return (from file in Directory.GetFiles("rewterwy")
                    where file == "*.reywery"
                    select file)
                   .Concat(
                   from childDir in Directory.GetDirectories("sdgsdafgsag")
                   from files in Find(childDir)
                   select files);
             */
        }

        //Функция по поиску изображений
        private void findChekItems()
        {
            if (filterMenu.DropDownItems.Cast<ToolStripMenuItem>().Any(item => item.Checked))
            {
                var basePath = @"\\fs63\UserData\Подготовка производства\Чертежи\";
                var formatDetector = new FormatDetector();

                var files = TraverseDrawingTree().ToList();

                var drawings = (from menuItem in filterMenu.DropDownItems.Cast<ToolStripMenuItem>()
                                where menuItem.Checked
                                let finder = new DrawingFinder(Path.Combine(basePath, menuItem.Text), formatDetector)
                                from drawing in finder.GetDrawings(files)
                                select SetDepartment(drawing, menuItem.Text)).ToList();

                foreach (var drawing in drawings.OrderBy(m => m.File).ToList())
                {
                    var item = listView1.Items.Add(drawing.Path);
                    item.Tag = drawing;
                    switch (drawing.Status)
                    {
                        case SPimg.Model.DrawingStatus.UnknownPaperSize:
                            item.SubItems.Add("Формат не определен");
                            break;
                        case SPimg.Model.DrawingStatus.Valid:
                            item.SubItems.Add(drawing.PageSize.PaperName);
                            break;
                    }
                }

                var drawingsHash = new HashSet<string>(drawings.Select(drawing => drawing.File).Distinct());
                NotFindList.Items.Clear();
                foreach (var file in files)
                    if (!drawingsHash.Contains(file))
                        NotFindList.Items.Add(file);

                tbPages.SelectedTab = tbPage2;
            }
            else
                MessageBox.Show("Не заданы филтры поиска");
        }

        private Drawing SetDepartment(Drawing drawing, string department)
        {
            drawing.Departmnet = department;
            return drawing;
        }

        //Запускает разузловку изделия
        private void bAddToList_Click(object sender, EventArgs e)
        {
            this.sbText.Text = "Разузловка запущена";

            foreach (var selectedRow in listBox1.SelectedItems.OfType<DataRowView>())
            {
                var itemName = (string)selectedRow[0];
                CreateTree(itemName, true);
            }

            this.sbText.Text = "Разузловка завершена";
            this.sbProgressBar.Value = 100;
        }

        //Поиск изображений на сервере
        private void bFind_Click_1(object sender, EventArgs e)
        {
            this.sbText.Text = "Поиск на сервере";
            this.ListFind.Items.Clear();
            findChekItems();
            this.sbText.Text = "Поиск заверщен";
        }

        private void filterMenu_Click(object sender, EventArgs e)
        {
            if (filterMenu.DropDownItems.Count == 0)
            {
                DirectoryInfo dir = new DirectoryInfo(@"\\fs63\UserData\Подготовка производства\Чертежи");
                DirectoryInfo[] directories = dir.GetDirectories();
                foreach (DirectoryInfo dirs in directories)
                {
                    filterMenu.DropDownItems.Add(dirs.Name).Click += new EventHandler(inFilterMenu_Click);
                }
            }
        }

        void inFilterMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemMenu = (ToolStripMenuItem)sender;
            if (itemMenu.Checked)
            {
                itemMenu.Checked = false;
            }
            else
            {
                itemMenu.Checked = true;
            }
        }

        private void delItemLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Remove(this.treeView1.SelectedNode);
        }

        private void cleaList_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        private void detectFormat(String path)
        {
            var errorMessages = new StringBuilder();
            var image = new Bitmap(path, true);

            //Высота 
            double Hmm = (image.Size.Height / image.VerticalResolution) * 25.4;
            //Ширина
            double Wmm = (image.Size.Width / image.HorizontalResolution) * 25.4;

            var pageSize = formatPage(Wmm, Hmm);
            if (pageSize != null)
            {
                listView1.Items
                   .Add(path).SubItems
                       .Add(pageSize.PaperName);
            }
            else
                errorMessages.Append("Не возможно определить размер листа для картинки ").AppendLine(path);

            if (errorMessages.Length != 0)
                MessageBox.Show(errorMessages.ToString());
        }

        private void detectFormatDelete(String path)
        {
            var errorMessages = new StringBuilder();
            var image = new Bitmap(path, true);

            //Высота 
            double Hmm = (image.Size.Height / image.VerticalResolution) * 25.4;
            //Ширина
            double Wmm = (image.Size.Width / image.HorizontalResolution) * 25.4;

            var pageSize = formatPage(Wmm, Hmm);
            if (pageSize != null)
            {
                listView1.Items
                   .Add(path).SubItems
                       .Add(pageSize.PaperName).BackColor = Color.BlueViolet;
            }
            else
                errorMessages.Append("Не возможно определить размер листа для картинки ").AppendLine(path);

            if (errorMessages.Length != 0)
                MessageBox.Show(errorMessages.ToString());
        }

        private PaperSize formatPage(double Wmm, double Hmm)
        {

            Wmm = Math.Round(Wmm, 0);
            Hmm = Math.Round(Hmm, 0);

            PaperSize a4albom = new PaperSize("A4 (Альбом)", 297, 210);
            PaperSize a4kniga = new PaperSize("A4 (Книга)", 210, 297);

            if (Wmm < a4albom.Width + 10 && Hmm < a4albom.Height + 10) { return a4albom; }
            if (Wmm < a4kniga.Width + 10 && Hmm < a4kniga.Height + 10) { return a4kniga; }

            PaperSize a3albom = new PaperSize("A3 (Альбом)", 420, 297);
            PaperSize a3kniga = new PaperSize("A3 (Книга)", 297, 420);

            if (Wmm < a3albom.Width + 44 && Hmm < a3albom.Height + 44) { return a3albom; }
            if (Wmm < a3kniga.Width + 44 && Hmm < a3kniga.Height + 44) { return a3kniga; }

            PaperSize a2albom = new PaperSize("A2 (Альбом)", 594, 420);
            PaperSize a2kniga = new PaperSize("A2 (Книга)", 420, 549);

            if (Wmm < a2albom.Width + 88 && Hmm < a2albom.Height + 88) { return a2albom; }
            if (Wmm < a2kniga.Width + 88 && Hmm < a2kniga.Height + 88) { return a2kniga; }

            PaperSize a1albom = new PaperSize("A1 (Альбом)", 549, 841);
            PaperSize a1kniga = new PaperSize("A1 (Книга)", 841, 549);

            if (Wmm < a1albom.Width + 176 && Hmm < a1albom.Height + 176) { return a1albom; }
            if (Wmm < a1kniga.Width + 176 && Hmm < a1kniga.Height + 176) { return a1kniga; }

            return null;
        }

        private void tPrint_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                var img = new Bitmap(item.Text, true);
                //Высота 
                double Hmm = (img.Size.Height / img.VerticalResolution) * 25.4;
                //Ширина
                double Wmm = (img.Size.Width / img.HorizontalResolution) * 25.4;
                using (var nowPrint = new PrintDocument())
                {
                    if (prSetting != null) { nowPrint.PrinterSettings = prSetting.PrinterSettings; }

                    nowPrint.PrintPage += (snd, args) =>
                    {
                        args.Graphics.DrawImage(img, -5, -5);
                    };

                    var outFormat = formatPage(Wmm, Hmm).PaperName;
                    var outFormatW = formatPage(Wmm, Hmm).Width;
                    var outFormatH = formatPage(Wmm, Hmm).Height;

                    nowPrint.QueryPageSettings += (snd, args) =>
                    {
                        foreach (PaperSize a in args.PageSettings.PrinterSettings.PaperSizes)
                        {
                            //args.PageSettings.Landscape = false;

                            //double Hm = Math.Round((a.Height * 0.3528) * 0.72, 0);
                            //double Wm = Math.Round((a.Width * 0.3528) * 0.72, 0);

                            if (a.Kind.ToString() == outFormat.Substring(0, 2))
                            {
                                args.PageSettings.PaperSize = a;
                                if (prSetting == null && outFormatW > outFormatH)
                                {
                                    args.PageSettings.Landscape = true;
                                }
                            }
                        }
                    };
                    nowPrint.Print();
                }
            }
        }

        private void editSettingPrinters_Click(object sender, EventArgs e)
        {
            prSetting = new PrintDialog();
            prSetting.ShowDialog();
        }

        private IEnumerable<string> TraverseDrawingTree()
        {
            var stack = new Stack<TreeNode>();
            PushNodes(stack, treeView1.Nodes);
            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node.Checked)
                    yield return node.Text;
                PushNodes(stack, node.Nodes);
            }
        }

        private void PushNodes(Stack<TreeNode> stack, TreeNodeCollection nodes)
        {
            foreach (var node in nodes.Cast<TreeNode>().Reverse())
                stack.Push(node);
        }

        private void CopyImagesToDestinationForlder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destinctFolderSelect = new FolderBrowserDialog();
            destinctFolderSelect.ShowDialog();

            var drawings = listView1.SelectedItems.Cast<ListViewItem>().Select(item => (Drawing)item.Tag);

            var repeatedDrawings = new HashSet<string>(from drawing in drawings
                                                       group drawing by drawing.File into drawingGroup
                                                       where drawingGroup.Count() > 1
                                                       select drawingGroup.Key);

            foreach (var drawing in drawings)
            {
                try
                {
                    if (repeatedDrawings.Contains(drawing.File))
                    {
                        var dst = Path.Combine(destinctFolderSelect.SelectedPath,
                            Path.GetDirectoryName(drawing.Path)
                            + Path.GetFileNameWithoutExtension(drawing.File)
                            + "_" + drawing.Departmnet
                            + "." + Path.GetExtension(drawing.File));
                        File.Copy(drawing.Path, dst);
                    }
                    else
                    {
                        var dst = Path.Combine(destinctFolderSelect.SelectedPath, drawing.File)+".tif";
                        File.Copy(drawing.Path, dst);
                    }
                }
                catch
                {
                    //MessageBox.Show("Ошибка при копировании файлов ");
                }
            }
        }
    }
}