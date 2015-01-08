using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using SPimg.Model;

namespace SPimg
{
    public class DrawingFinder
    {
        public DrawingFinder(string baseDirrectory, FormatDetector formatDetector)
        {
            if (baseDirrectory == null) throw new ArgumentNullException("baseDirrectory");
            if (formatDetector == null) throw new ArgumentNullException("formatDetector");

            _baseDirrectory = baseDirrectory;
            _formatDetector = formatDetector;
        }

        public IEnumerable<Drawing> GetDrawings(IEnumerable<string> files)
        {
            if (files == null) throw new ArgumentNullException("files");

            return from file in files
                   let basePath = Path.Combine(_baseDirrectory, file)
                   let dirName = Path.GetDirectoryName(basePath)
                   let fileName = Path.GetFileName(basePath)
                   from childDir in Directory.GetDirectories(dirName, fileName.Substring(0, 7) + "*")
                   from childFile in Directory.GetFiles(childDir, fileName + "*" )
                   select GetDrawing(file, childFile);
        }

        private Drawing GetDrawing(string file, string path)
        {
            try
            {
                return new Drawing
                {
                    File = file,
                    Path = path,
                    PageSize = _formatDetector.DetectFormat(path),
                    Status = DrawingStatus.Valid
                };
            }
            catch (UknownDrawingFormatException)
            {
                return new Drawing
                {
                    File = file,
                    Path = path,
                    PageSize = null,
                    Status = DrawingStatus.UnknownPaperSize
                };
            }
        }

        private readonly string _baseDirrectory;
        private readonly FormatDetector _formatDetector;
    }
}
