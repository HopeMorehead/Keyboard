using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userWantsToExit = false;

            

            while (!userWantsToExit)
            {

                string ya = Console.ReadLine();


                if (ya == "a")
                {

                    var myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"c:\users\wecancodeit\documents\visual studio 2015\Projects\Keyboard\Keyboard\sound\A-A-3.wav";

                    myPlayer.PlaySync();
                }

                 if (ya == "b")
                {

                    var myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"c:\users\wecancodeit\documents\visual studio 2015\Projects\Keyboard\Keyboard\sound\B_B-3.wav";

                    myPlayer.PlaySync();
                }

                 if (ya == "d")
                {

                    var myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"c:\users\wecancodeit\documents\visual studio 2015\Projects\Keyboard\Keyboard\sound\D _D-3.wav";
                    myPlayer.PlaySync();
                }

                 if (ya == "f")
                {

                    var myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"c:\users\wecancodeit\documents\visual studio 2015\Projects\Keyboard\Keyboard\sound\G_b-F#.wav";

                    myPlayer.PlaySync();
                }
                 if (ya == "g")
                {
                    
                    var myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"c:\users\wecancodeit\documents\visual studio 2015\Projects\Keyboard\Keyboard\sound\G_G-3.wav";

                    myPlayer.PlaySync();
                }
                if (ya == "h")
                {


                    var myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"c:\users\wecancodeit\documents\visual studio 2015\Projects\Keyboard\Keyboard\sound\B_1.wav";




                    myPlayer.PlaySync();
                }
                if (ya == "j")
                {

                    var myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"c:\users\wecancodeit\documents\visual studio 2015\Projects\Keyboard\Keyboard\sound\wondernote.wav";

                    myPlayer.PlaySync();


                }


                if (ya == "exit")
                    userWantsToExit = true;
                



            }

        }
    }
}
