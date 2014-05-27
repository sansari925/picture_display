using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace picture_display.Tables
{
    public class TableImages
    {
        //[SQLite.PrimaryKey]
        //public int ID { get; set; }
        //public string imagePath { get; set; }
        //public string imageName { get; set; }
        //public string imageDate { get; set; }
        //public byte[] binaryLargeImage { get; set; }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string imagePath { get; set; }
        public string imageName { get; set; }
        public string imageDate { get; set; }
        public byte[] binaryLargeImage { get; set; }
    }
}
