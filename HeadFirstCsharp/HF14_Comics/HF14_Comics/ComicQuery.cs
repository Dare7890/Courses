using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HF14_Comics
{

    class ComicQuery
    {
        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public string Description { get; private set; }
        public BitmapImage Image { get; private set; }

        public ComicQuery(string title, string subtitle, string description,
            BitmapImage image)
        {
            this.Title = title;
            this.Subtitle = subtitle;
            this.Description = description;
            this.Image = image;
        }
    }
}
