using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Topic_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            drawBart();
            drawFred();
            drawDie();
            knockKnockJoke();

        }
        public static void drawBart()
        {
            Console.WriteLine(" |\\/\\/\\/\\/\\/|");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |    __  __|");
            Console.WriteLine(" |   /  \\/  \\");
            Console.WriteLine(" |  (o   )o  )");
            Console.WriteLine(" /c   \\__/ --.");
            Console.WriteLine(" \\_   ,     -'");
            Console.WriteLine(" |  '\\_______)");
            Console.WriteLine(" |      _)");
            Console.WriteLine(" |     |");
            Console.WriteLine(")/`-----'\\");
            Console.WriteLine("/         \\");

        }
        public static void drawFred()
        {
            Console.WriteLine("                                                                                                                                     ...'.......'''',,,,,'''.....''....................                       .....'''''............'',,,,;;,.                                                              \r\n");
            Console.WriteLine("                                                                              ......''''''''.....                               ...'',,;:;,;;;;:cccclloollcccc::;;;;;;;;::;;;;::;;,,''''''..                .':c::cc:;,,,'''...'...',;::cllclc,.                                                            \r\n");
            Console.WriteLine("                                                                         ...',:;,,,:cc::;,,,,,;;;,'..                       ...';;;;,,;,,,,,;,,;;;;:cllloooool::::::::c::ccc::ccc:;;,,,,,,,,,'.            .,cll::::;,'...............',,,;;:c:,.                                                           \r\n");
            Console.WriteLine("                                                                       .,;:::::;,'',;;,''''''',,;:ccc:'.                 ...,,,;;,,,''''''',,,,,,;;:cloodxxddolllcclllllllollllllllc:;;;;;;,;:;,..        .;:col:;,,',,;;;;;;;;,,,''.....',',;::,.                                                          \r\n");
            Console.WriteLine("                                                                     .,;;:cc:;;,'...............';;;:odc'              ..',,,;,;;,,,,,'',;,,,,;;:cccclodxxxxxxxxdoooodddoddddddxdddolc:::;;;;;;;;,..     .,:cllc;,,;::cccccccc::::;;;,,'.....,::;'.                                                         \r\n");
            Console.WriteLine("                                                                    .,,,;;:;,,,'..............''''''';ldl:.          ..,,'',;;,,,,,,,;;;;,,,,;:ccc:::clodxxxdxkxxddodddoolodxxxxxxxddllllcc::;;;,,,'.    .,:llc:;;:cccclllccccccc:::;;,,'....';;;,.                                                         \r\n");
            Console.WriteLine("                                                                   ..'',;;;,'.........''',,,,,;;;;;,,,;clol,.       ..''..',;;,''',;;:::;,,,;;:cccc::cclodxddxxxxxxdoolllloododdxxxddoloooolc:::;;;;;'.  .,:cc;',::ccllllllllcccc::::;;;,'...,;;;,.                                                         \r\n");
            Console.WriteLine("                                                                   .''',,,,........''',,,,;;;;::::ccc:;,;clc'      ..'....',,;,,;;::::::::;;::cc:::::::clddoooddddxddoooollllllloodddooooooollccc:;,;,,.  ':cl,.'ccllllllllllcccc:::::;;,,..',;;;,.                                                         \r\n");
            Console.WriteLine("                                                                   ...',,'.  .....''',,,;;;;;:::ccclll:'';:c;.    .......'',,;:::::::c::;::cclllccc::::clooolodxxdoooooooollllllllllccclcccccccccc::;;;,...;lo,..:clllooollllcccc::::;;;,'..,;;:;,.                                                         \r\n");
            Console.WriteLine("                                                                   ...,;,.  .....''',,,;;;;:::::ccllolc,';cc,.   ...''..''',,;;;;;;,;;;,,',;;:llc::;:::ccloooloollllccclollc:;,'....       ....',:lc::;;;'..:o:..,:cllllllllcccc:::;;;,,'..';:c:;,.                                                         \r\n");
            Console.WriteLine("                                                                   ...,;;. ......''',,;;;;;::::cccllloc'':ll'    .......''',,,'...            ......',,,::cclllllllllcc:'...                     'cc::::::,.'cl;..,:cccccllccccc::;;;,'....,;loc;'.                                                         \r\n");
            Console.WriteLine("                                                                   ...,::.  ....'''',,,;;;;;::::ccclll:',:ll;.   ......'''''.                          .,:::::ccllollcc;.                        .cc:::ccc;'.':c,..,::c:::ccccc:::;,''....',;ccc;.                                                          \r\n");
            Console.WriteLine("                                                                   ...,:c,  .....''',,,;;;;;;:::::cccc;',cllc.  .......''','.                        ..,::cccccccoolcccc:,'.........             'lolcclol:;,..:c,..,;:::::::::;,,''.....',:::,,'.                                                          \r\n");
            Console.WriteLine("                                                                    ..';cc.   ....''',,,;;;;;;;;;:::c:,,;cc,.   ......'''.''.            .........'',;;;;;::ccllllooolccccccc:;;:::;;;;;,''.    .;oodlccllc:::..;:'...',;;;,,,,''......';:cc:;,..                                                           \r\n");
            Console.WriteLine("                                                                     .';cc:.    ....''',,,,;,,;;;;::;,',;:,.    ....'',,,,''.      .....',;;;;;;;;;;;;;;,,,;:clloddddoll:::c:;,'''....,;:lll:,',:oolooc:::;;':c'.,:,.  ...''.........';::ccc;,'.                                                            \r\n");
            Console.WriteLine("                                                                      .'',::'.  ........'',,,,,,;;;;,';;,'.   ........''''.......'',,,''............''',,,,,;:lloddddolc:;;,'..         .';ldlcclooooollc:;;,,;' .';;,............',;;;;;;;;'..                                                             \r\n");
            Console.WriteLine("                                                                        ..;:c:'.   .......'''',,,,,,'';,'..   ..'...........'',,,,,,;,..             ...',,,,;:codddolc:;;'.               .,coollcllllc:;;;;,'.   .';:;;;;::::::::;,,'.....                                                                \r\n");
            Console.WriteLine("                                                                         ..,;::;'..    .........',,,,;;,..   ....''..........''',,,'.                   ..'',;:loddoc::;,...',,;,'.          .,llcccc:cc:;,''''..    ..',:ccc::;,,''......                                                                  \r\n");
            Console.WriteLine("                                                                           ..',,;,,,'...........';:;;;,.      ........''......'',,.      ..,:::;'.        ..,;:cloool:;;:okKXNWWWNKOd;.        '::::c:::;,,,'''..        ...........                                                                        \r\n");
            Console.WriteLine("                                                                              .....',;;::;;:::c:;;;,,'.       ....'','''......',,.    .:d0XWWWWWNKx;.      .',;clccc:;,c0WWWWWWWWMMWWN0c.       .;::::::;,''''''.                                                                                           \r\n");
            Console.WriteLine("                                                                                  ....''',;:::;;,....         .''',,,,,,'''''',;'    ;OWWWWNNNWMMWMNx'      .',:::;,;,,oNWWWNKKKKNWWWWWNx.       ,c:::::;;,,''''.                                                                                           \r\n");
            Console.WriteLine("                                                                                        ........              ....''',,,''''',::.   ,kXWWX0OO00KNWMMWOl'    .'',,'.....:k0000dclk00NWWWWWd.      ,cllc:;;;,,,'''.                                                                                           \r\n");
            Console.WriteLine("                                                                                                               ..........',',;c;.   ,xKXK0o,,lxxONWWMNXl                 ....   .coOWWMMMK,      ;lccc:;,,,,,,,'.                                                                                           \r\n");
            Console.WriteLine("                                                                                                                ....''''.',,,:l:.   .lOkdc.  .coxXXOo:;.                           .oXWWMX;     .clccc:;;,,,,;,,'.                                                                                          \r\n");
            Console.WriteLine("                                                                                                               ....'',,,'',;;:lo,    .lxc..  .':xd,.                  ...            cKXXk,.....collllc:::;;,,,;,'..                                                                                        \r\n");
            Console.WriteLine("                                                                                                              ..'',;;,,,;,,,;:clc'    .:lc,..'cko.                   ,dxl.           .:lcc:::::cloolllllcc:;;,,,,,,,'.                                                                                      \r\n");
            Console.WriteLine("                                                                                                          ....'',,;;,,,,,,,,;,;;:;,'',;:cllllodo;.                     .            .,cllllooddddddoodddolcc::;;;;;,,,'.                                                                                    \r\n");
            Console.WriteLine("                                                                                                       .....',,,;;;;,;;;,,,,,;;;:::cllllllooodooolc;,...                      ...';loddddxddxxkkkkkkxxxxdoddlc;;;;;,,,,,'.                                                                                  \r\n");
            Console.WriteLine("                                                                                                     ...'',;;;;,;::;;;,,'',;;:cclooooodxxxddddxxxxxkkdddolc::;;,'.........',;clddoodddxkkkkkkkOkkOOOOkxxxddxdol:;,,,,,,,''.                                                                                 \r\n");
            Console.WriteLine("                                                                                                    ...'',,,,;;;,,;,,''..,;:cllloodoooodxxxxdxxkkkkkkxxxkOOOOOOOkxdocccccodxxxxxxdddxkkkkkkOOO00OxclxOkkkxlldxxl:;,,,,,;,,'.                                                                                \r\n");
            Console.WriteLine("                                                                                                   ..''''''',,,,,,,,,...,;,;cllllllooolcoddxxxxxxxxxkkkkkkkkOOOOkkxxxolllodxxxxxdxkkkkkkkOOOO0000kcckOOOkxc:oxxxo:;;;,,,,,,'.                                                                               \r\n");
            Console.WriteLine("                                                                                                   .....',,,,,,;;,''..',:::c;'';::cloc'.:ooodddddxxxxkkkkkkkkOOOkkkkkxc:cclloooodxxkkkkkkOOOO000000000OOOOkkxxkkxo;,,,;;,,;,.                                                                               \r\n");
            Console.WriteLine("                                                                                                    ...'',,,,,,;,,'..';:::::;'';::::cc::coooodddddddxkkkkkkOOOOOkkkkkdccc:;:loodddxxkkkkkkkOOOOOOOOOOOOkxdxkkkkkkxc,,,;;,,;,.                                                                               \r\n");
            Console.WriteLine("                                                                                                    ...'',,,;,,,'.. .';:::;;:;:::::::ccccclooooodddddddxxkkkkkkOOkkxxdlc::;:clooodddxxxxxxxkkkkkkkkkkkOkc,lkkkkkxxo::;;;,,,,.                                                                               \r\n");
            Console.WriteLine("                                                                                                     ..'',;;,,,,'.  ..,;;;;;;;;;,';::cccccclloddooodddddxxkkkkkkkkxdddl;;:::ccllooddooddddxxkkkkkkkkkkkkxxkkkxxxxxoc:;;,'','.                                                                               \r\n");
            Console.WriteLine("                                                                                                     ....',,,,,'.   ..',,,,;,;;,..,::::::::ccclollllodddddxxxxxdxxdddoc;,;:::cclodddoooooodxxdxxkkxxkkkkkkkxxdddool:,','..'.                                                                                \r\n");
            Console.WriteLine("                                                                                                      ...''',;'.     ..''',,,,,;;;::::::c::c::ccccllloodoodxxxxxddddool;,,;:::ccccclooooooodddddxxxxxxxxxxdddollcc:;,'''....                                                                                \r\n");
            Console.WriteLine("                                                                                                       ...'''.        .....'''',,;;;:::::c:::::cccccclllloodddddooooooc;,,,;;;::;;:cccclllloooooodoodddooooolcc:::;,'''....                                                                                 \r\n");
            Console.WriteLine("                                                                                                         ....          .......'',,;;;;;;;:;;;::::::cccccclllllooollllc:,,;;,;;;;;;;;;;::cccllllllllooolllcccc:;;;,,,''....                                                                                  \r\n");
            Console.WriteLine("                                                                                                                           .......',,,,,,,,,,;;;;;;;::::::::::cccccc::;,',,',,,;;;;;;;;;::cccc:ccc::::::::;;;,,,,'',''..                                                                                    \r\n");
            Console.WriteLine("                                                                                                                                ....''''''''''''''',,,,;;;;;;;::::;;;;,'....'''.'''',,,,;;;;;,,,;;;;;,,''''''''...''...                                                                                     \r\n");
            Console.WriteLine("                                                                                                                                    .......................'',,,'''''......................................      ..                                                                                         \r\n");
            Console.WriteLine("                                                                                                                                           ................                                                                                                                                                 \r\n");

        }

        public static void drawDie()
        {
         
                Console.WriteLine("-----");
                Console.WriteLine("|    |");
                Console.WriteLine("|  o |");
                Console.WriteLine("|    |");
                Console.WriteLine("-----");
           
        }
    

        public static void knockKnockJoke()
        {
            int i = 1;
            Console.WriteLine("Knock Knock");
            Thread.Sleep(500);
            while (i == 1)
            {
                Console.WriteLine("Whos there?");
                Thread.Sleep(500);
            }

         

        }
    }
}