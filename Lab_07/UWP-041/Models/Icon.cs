using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_041.Models
{
    public class Icon
    {
        public string ImagePath{ get; set; }
        
    }

    public class IconManager
    {
        public static List<Icon> GetIcons()
        {
            var icons = new List<Icon>();
            icons.Add(new Icon { ImagePath = "Assets/male-01.png" });
            icons.Add(new Icon { ImagePath = "Assets/male-02.png" });
            icons.Add(new Icon { ImagePath = "Assets/male-03.png" });
            icons.Add(new Icon { ImagePath = "Assets/female-01.png" });
            icons.Add(new Icon { ImagePath = "Assets/female-02.png" });
            icons.Add(new Icon { ImagePath = "Assets/female-03.png" });
            
            return icons;

        }
    }
}
