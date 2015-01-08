using System.Drawing.Printing;

namespace SPimg.Model
{
    public sealed class Drawing
    {
        #region public string Departmnet

        private string m_Departmnet;

        public string Departmnet
        {
            get { return m_Departmnet; }
            set { m_Departmnet = value; }
        }

        #endregion

        #region public string File

        private string m_File;

        public string File
        {
            get { return m_File; }
            set { m_File = value; }
        }

        #endregion

        #region public PaperSize PageSize

        private PaperSize m_PageSize;

        public PaperSize PageSize
        {
            get { return m_PageSize; }
            set { m_PageSize = value; }
        }

        #endregion

        #region public string Path

        private string m_Path;

        public string Path
        {
            get { return m_Path; }
            set { m_Path = value; }
        }

        #endregion

        #region public DrawingStatus Status

        private DrawingStatus m_Status;

        public DrawingStatus Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }

        #endregion
    }
}