using System;

namespace Övning_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ett program som skriver ut följande rektanglar på konsolen med hjälp av loopar:
            //1.            2.          3.          4.          5.          6.                      7.       8.     9.
            //#-------#-#-  #---#---    ##------    --#--#--    #---#---    ###---##--##--##--##--  --#--##  --#--  #---#
            //-#-------#-#  -#---#--    --##----    --#--#--    -#-#----    ###---##--##--##--##--  ---#-##  -----  -#-#-
            //--#-----#-#-  --#---#-    ----##--    ########    --#-----    ###---WWWWWW~~~~~~~~~~  ----#--  --#--  --o--
            //---#-----#-#  ---#---#    ------##    --#--#--    -#-#----    ------################  -----#-  --#--  -#-#-
            //                                                                                                      #---#

            Console.WriteLine("1.");
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (row == column)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
