namespace Solution
{
    using System;
    public class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            int scale = 10;
            int ein = 0;
            int zwei = 0;
            int drei = 0;
            int vier = 0;
            int test = 0;


            for (int i = 0; i < scale; i++)
            {
                for (int j = 0; j < scale; j++)
                {
                    if (field[i,j] == 1)
                    {
                        if (i!=0)
                        {
                            if (field[i - 1, j] == 1)
                            {
                                goto checkpoint1;
                            }
                        }
                        if (j != scale - 1)
                        {
                            if (field[i, j + 1] == 1)
                            {
                                test++;
                                j++;

                                if (i != 0)
                                {
                                    if (field[i - 1, j] == 1)
                                    {
                                        return false;
                                    }
                                }
                                if (j != scale - 1)
                                {
                                    if (field[i, j + 1] == 1)
                                    {
                                        j++;

                                        if (i != 0)
                                        {
                                            if (field[i - 1, j] == 1)
                                            {
                                                return false;
                                            }
                                        }
                                        if (j != scale - 1)
                                        {
                                            if (field[i, j + 1] == 1)
                                            {
                                                j++;

                                                if (i != 0)
                                                {
                                                    if (field[i - 1, j] == 1)
                                                    {
                                                        return false;
                                                    }
                                                }
                                                if (j != scale - 1)
                                                {
                                                    if (field[i, j + 1] == 1)
                                                    {
                                                        return false;
                                                    }
                                                }
                                                if (i != scale - 1)
                                                {
                                                    if (field[i + 1, j] == 1)
                                                    {
                                                        return false;
                                                    }
                                                }
                                                vier++;
                                                goto checkpoint1;
                                            }
                                        }
                                        if (i != scale - 1)
                                        {
                                            if (field[i + 1, j] == 1)
                                            {
                                                return false;
                                            }
                                        }
                                        drei++;
                                        goto checkpoint1;
                                    }
                                }
                                if (i != scale - 1)
                                {
                                    if (field[i + 1, j] == 1)
                                    {
                                        return false;
                                    }
                                }
                                zwei++;
                                goto checkpoint1;
                            }
                        }
                        if (i != scale - 1)
                        {
                            if (field[i + 1, j] == 1)
                            {
                                test++;
                                if (j != 0)
                                {
                                    if (field[i, j - 1] == 1)
                                    {
                                        return false;
                                    }
                                }
                                if (j != scale - 1)
                                {
                                    if (field[i, j + 1] == 1)
                                    {
                                        return false;
                                    }
                                }
                                if (i != scale - 1)
                                {
                                    if (j != 0)
                                    {
                                        if (field[i, j - 1] == 1)
                                        {
                                            return false;
                                        }
                                    }
                                    if (j != scale - 1)
                                    {
                                        if (field[i, j + 1] == 1)
                                        {
                                            return false;
                                        }
                                    }
                                    if (i != scale - 1)
                                    {
                                        if (j != 0)
                                        {
                                            if (field[i, j - 1] == 1)
                                            {
                                                return false;
                                            }
                                        }
                                        if (j != scale - 1)
                                        {
                                            if (field[i, j + 1] == 1)
                                            {
                                                return false;
                                            }
                                        }
                                        if (i != scale - 1)
                                        {
                                            if (j != 0)
                                            {
                                                if (field[i, j - 1] == 1)
                                                {
                                                    return false;
                                                }
                                            }
                                            if (j != scale - 1)
                                            {
                                                if (field[i, j + 1] == 1)
                                                {
                                                    return false;
                                                }
                                            }
                                            if (i != scale - 1)
                                            {
                                                return false;
                                            }
                                        }
                                        vier++;
                                        goto checkpoint1;
                                    }
                                    drei++;
                                    goto checkpoint1;
                                }
                                zwei++;
                                goto checkpoint1;
                            }
                        }
                        if(test == 0)
                        {
                            ein++;
                        }
                        else if (test == 2)
                        {
                            return false;
                        }
                        checkpoint1:;
                       
                    }
                }
            }
            if (ein != 4 || zwei != 3 || drei != 2 || vier != 1)
            {
                return false;
            }
            for (int i = 0; i < scale; i++)
            {
                for (int j = 0; j < scale; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        if (field[i, j] == 1 && field[i + 1, j + 1] == 1)
                        {
                            return false;
                        }
                    }
                    else if (i == scale - 1 && j == 0)
                    {
                        if (field[i, j] == 1 && field[i - 1, j + 1] == 1)
                        {
                            return false;
                        }
                    }
                    else if (i == 0 && j == scale - 1)
                    {
                        if (field[i, j] == 1 && field[i + 1, j - 1] == 1)
                        {
                            return false;
                        }
                    }
                    else if (i == scale - 1 && j == scale - 1)
                    {
                        if (field[i, j] == 1 && field[i - 1, j - 1] == 1)
                        {
                            return false;
                        }
                    }
                    else if (i == 0)
                    {
                        if (field[i, j] == 1 && field[i + 1, j + 1] == 1)
                        {
                            return false;
                        }
                        else if (field[i, j] == 1 && field[i + 1, j - 1] == 1)
                        {
                            return false;
                        }
                    }
                    else if (j == 0)
                    {
                        if (field[i, j] == 1 && field[i + 1, j + 1] == 1)
                        {
                            return false;
                        }
                        else if (field[i, j] == 1 && field[i - 1, j + 1] == 1)
                        {
                            return false;
                        }
                    }
                    else if (i == scale - 1)
                    {
                        if (field[i, j] == 1 && field[i - 1, j + 1] == 1)
                        {
                            return false;
                        }
                        else if (field[i, j] == 1 && field[i - 1, j - 1] == 1)
                        {
                            return false;
                        }
                    }
                    else if (j == scale - 1)
                    {
                        if (field[i, j] == 1 && field[i + 1, j - 1] == 1)
                        {
                            return false;
                        }
                        else if (field[i, j] == 1 && field[i - 1, j - 1] == 1)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (field[i, j] == 1 && field[i + 1, j + 1] == 1)
                        {
                            return false;
                        }
                        else if (field[i, j] == 1 && field[i + 1, j - 1] == 1)
                        {
                            return false;
                        }
                        else if (field[i, j] == 1 && field[i - 1, j + 1] == 1)
                        {
                            return false;
                        }
                        else if (field[i, j] == 1 && field[i - 1, j - 1] == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}