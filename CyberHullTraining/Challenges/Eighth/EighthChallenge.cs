namespace CyberHullTraining.Challenges.Eighth
{
    internal sealed class EighthChallenge : IChallenge
    {
        public void Act()
        {
            char[,] values =
            {
               { '1', '2', '3' },
               { '4', '5', '6' },
               { '7', '8', '9' }
            };

            IDictionary<string, char> playersSigns = new Dictionary<string, char>
            {
                {"Player 1", 'O' },
                {"Player 2", 'X' }
            };

            while (true)
            {
                KeyValuePair<string, char> playerSing = playersSigns.First();
                Console.WriteLine(GenerateGameField(values));
                Console.WriteLine($"{playerSing.Key}, your turn");

                playersSigns = playersSigns.Reverse().ToDictionary(x => x.Key, x => x.Value);

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int value))
                {
                    Console.WriteLine("Value is not value");
                    continue;
                }

                if (value > 0 && value <= 9)
                {
                    switch (value)
                    {
                        case 1:
                            values[0, 0] = playerSing.Value;
                            break;
                        case 2:
                            values[0, 1] = playerSing.Value;
                            break;
                        case 3:
                            values[0, 2] = playerSing.Value;
                            break;
                        case 4:
                            values[1, 0] = playerSing.Value;
                            break;
                        case 5:
                            values[1, 1] = playerSing.Value;
                            break;
                        case 6:
                            values[1, 2] = playerSing.Value;
                            break;
                        case 7:
                            values[2, 0] = playerSing.Value;
                            break;
                        case 8:
                            values[2, 1] = playerSing.Value;
                            break;
                        case 9:
                            values[2, 2] = playerSing.Value;
                            break;
                        default:
                            break;
                    }

                    if (IsWin(values, playerSing.Value))
                    {
                        Console.WriteLine($"{playerSing.Key} has won!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Value is not value");
                }
            }
        }

        private string GenerateGameField(char[,] values)
        {
            return 
                $"------------" + Environment.NewLine +
                $" {values[0, 0]} | {values[0, 1]} | {values[0, 2]} |" + Environment.NewLine +
                $"------------" + Environment.NewLine +
                $" {values[1, 0]} | {values[1, 1]} | {values[1, 2]} |" + Environment.NewLine +
                $"------------" + Environment.NewLine +
                $" {values[2, 0]} | {values[2, 1]} | {values[2, 2]} |" + Environment.NewLine +
                $"------------" + Environment.NewLine;
        }

        private bool IsWin(char[,] values, char playerSign)
        {
            bool isWin;
            for (int i = 0; i < 3; i++)
            {
                isWin = values.GetRow(i).All(sign => sign == playerSign);
                if(isWin == true)
                {
                    return isWin;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                isWin = values.GetColumn(i).All(sign => sign == playerSign);
                if (isWin == true)
                {
                    return isWin;
                }
            }

            return default;
        }
    }
}
