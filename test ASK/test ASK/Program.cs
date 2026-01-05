using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Clear + Home + Hide cursor
        Console.Write("\x1b[2J\x1b[H\x1b[?25l");

        try
        {
            // TrueColor ANSI 팔레트 (몸 파랑, 껍질 분홍, 점 보라, 소용돌이 빨강, 눈 연두)
            string Body = Fg(90, 190, 220); // B
            string Shell = Fg(255, 170, 190); // S
            string Spots = Fg(140, 90, 220); // P
            string Spiral = Fg(210, 60, 70); // R
            string Eye = Fg(190, 240, 170); // E
            string Pupil = Fg(30, 30, 30); // K
            string Slime = Fg(180, 240, 140); // G
            string Reset = "\x1b[0m";

            // 맵 문자:
            // B=몸, S=껍질, P=점, R=소용돌이, E=눈, K=동공, G=바닥, .=공백
            // ✅ 몸(B)과 껍질(S)이 맞닿게(연결) 배치한 버전
            string[] art =
            {
                "....BBBBEEKEEBB....BBBBEEKEEBB............................",
                "....BBBBBEEEEE......BBBBBEEEEE..................SSSSSS.....",
                ".....BBBBBBBBB........BBBBBBBB..............SSSSSSSSSS.....",
                "......BBBBBBBB..........BBBBBB..........SSSSSPPPPPSSSSS....",
                ".......BBBBBBB............BBBBB........SSSSPPPPPPPPSSSS....",
                "......BBBBBBBB..........BBBBBBB.......SSSPPPSSRRSSSSSSS....",
                ".....BBBBBBBBBB........BBBBBBBB......SSSPPSSRRRSSSSSSSS....",
                "....BBBBBBBBBBBB......BBBBBBBBB.....SSSPPSSRRRSSSSSSSSS....",
                "...BBBBBBBBBBBBBB....BBBBBBBBBBB....SSSPPSSRRRSSSSSSSS.....",
                "..BBBBBBBBBBBBBBBBBBBBBBBBBBBBBB....SSSPPPSSRRSSSSSS......",
                "..BBBBBBBBBBBBBBBBBBBBBBBBBBBBB......SSSPPPPPPPSSSS.......",
                "...BBBBBBBBBBBBBBBBBBBBBBBBBBB..........SSSSPPPPSSSS.......",
                "....BBBBBBBBBBBBBBBBBBBBBBBBB.............SSSSSSSSSS.......",
                ".....BBBBBBBBBBBBBBBBBBBBBBB................SSSSSS.........",
                "......BBBBBBBBBBBBBBBBBBBBB..................SSSS..........",
                ".......GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG..................",
            };

            int width = art.Max(s => s.Length);

            foreach (var line in art)
            {
                var sb = new StringBuilder(width * 10);

                foreach (char c in line.PadRight(width, '.'))
                {
                    switch (c)
                    {
                        case 'B': sb.Append(Body).Append('█'); break;
                        case 'S': sb.Append(Shell).Append('█'); break;
                        case 'P': sb.Append(Spots).Append('█'); break;
                        case 'R': sb.Append(Spiral).Append('█'); break;
                        case 'E': sb.Append(Eye).Append('█'); break;
                        case 'K': sb.Append(Pupil).Append('█'); break;
                        case 'G': sb.Append(Slime).Append('█'); break;
                        default: sb.Append(Reset).Append(' '); break;
                    }
                }

                sb.Append(Reset);
                Console.WriteLine(sb.ToString());
            }

            Console.WriteLine("\n" + Reset + "핑핑이(게리) 컬러 ASCII - 아무 키나 누르면 종료");
            Console.ReadKey(true);
        }
        finally
        {
            Console.Write("\x1b[?25h\x1b[0m");
        }
    }

    static string Fg(int r, int g, int b) => $"\x1b[38;2;{r};{g};{b}m";
}
