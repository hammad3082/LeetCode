using System.Text;


StringBuilder sb = new StringBuilder();
string s = "GRGGLGRGLL";
for(int i = 0 ; i < 5; i++)
{
    sb.Append(s);
}

bool res = IsRobotBounded(sb.ToString());
bool IsRobotBounded(string instructions)
{
    int x = 0, y = 0;

    int Di = 1;
    for (int i = 0; i < instructions.Length; i++)
    {
        switch (instructions[i])
        {
            case 'G':
                {
                    if (Di == 1 ) { y++; }
                    else if (Di == 3) { y--; }
                    else if (Di == 2) { x++; }
                    else if (Di == 4) { x--; }
                }
                break;
            case 'L':
                {
                    if (Di == 1) { Di = 4; }
                    else if (Di == 2) { Di = 1; }
                    else if (Di == 3) { Di = 2; }
                    else if (Di == 4) { Di = 3; }
                }
                break;
            case 'R':
                {
                    if (Di == 1) { Di = 2; }
                    else if (Di == 2) { Di = 3; }
                    else if (Di == 3) { Di = 4; }
                    else if (Di == 4) { Di = 1; }
                }
                break;
        };

        Console.WriteLine("(" + x.ToString() + ',' + y.ToString() + ',' + Di + "),");
    }

    if ((x == 0 && y == 0) || (Di != 1))
        return true;
    return false;
}
bool IsRobotBounded1(string instructions) {
    int x = 0, y = 0;

    int xd = 0, yd = 1;
    for (int i = 0; i < instructions.Length; i++)
    {
        switch(instructions[i]){
            case 'G':
                {
                    if (yd != 0)
                    {
                        if (yd == 1)
                        {
                            y++;
                        }
                        else if (yd == -1)
                        {
                            y--;
                        }
                    }

                    if (xd != 0)
                    {
                        if (xd == 1)
                        {
                            x++;
                        }
                        else if (xd == -1)
                        {
                            x--;
                        }
                    }
                }
                break;
            case 'L':
                {
                    if (xd == 0 && yd == 1)
                    {
                        xd = -1;
                        yd = 0;
                    }
                    else if (xd == -1 && yd == 0)
                    {
                        xd = 0;
                        yd = -1;
                    }
                    else if (xd == 0 && yd == -1)
                    {
                        yd = 0;
                        xd = 1;
                    }
                    else
                    {
                        xd = 0;
                        yd = 1;
                    }
                }
                break;
            case 'R':
                {
                    if (xd == 0 && yd == 1)
                    {
                        xd = 1;
                        yd = 0;
                    }
                    else if (xd == 1 && yd == 0)
                    {
                        xd = 0;
                        yd = -1;
                    }
                    else if (xd == 0 && yd == -1)
                    {
                        yd = 0;
                        xd = -1;
                    }
                    else
                    {
                        xd = 0;
                        yd = -1;
                    }
                }
                break;
        };
    }

    if ((x == 0 && y == 0) || (yd != 1))
        return true;
    return false;
}

Console.WriteLine(res);
