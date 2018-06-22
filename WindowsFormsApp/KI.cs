using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class KI
    {
        Level level; 
        enum Level
        {
            leicht,
            mittel,
            schwer
        }

        Level getLevel()                    // liest level des KIs
        {
            return level; 
        }
        void setLevel(Level newLevel)           // gibt dem KI eine level
        {
            level = newLevel;
        }

        bool istKI()
        {
            return true;
        }

    
        

    }
}
