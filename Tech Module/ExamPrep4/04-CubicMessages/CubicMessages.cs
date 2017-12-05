using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }

                var messageLength = int.Parse(Console.ReadLine());
                var decryptedMessage = string.Empty;

                var pattern = @"^(?<code1>\d+)(?<message>[a-zA-Z]+)(?<code2>[^a-zA-Z]*?)$";

                var matchedMessage = Regex.Match(input, pattern);

                if (matchedMessage.Success)
                {
                    var message = matchedMessage.Groups["message"].Value;
                    string code1 = matchedMessage.Groups["code1"].Value;
                    string code2 = matchedMessage.Groups["code2"].Value;

                    if (message.Length == messageLength)
                    {
                        if (!result.ContainsKey(message))
                        {
                            result[message] = string.Empty;
                        }

                        for (int i = 0; i < code1.Length; i++)
                        {
                            var currentDigit = int.Parse(code1[i].ToString());

                            if (currentDigit < messageLength)
                            {
                                decryptedMessage += message[currentDigit];
                            }
                            else
                            {
                                decryptedMessage += " ";
                            }
                        }
                        for (int i = 0; i < code2.Length; i++)
                        {
                            if (char.IsDigit(code2[i]))
                            {
                                var currentDigit = int.Parse(code2[i].ToString());

                                if (currentDigit < messageLength)
                                {
                                    decryptedMessage += message[currentDigit];
                                }
                                else
                                {
                                    decryptedMessage += " ";
                                }
                            }
                        }
                        result[message] = decryptedMessage;
                    }
                }
            }

            foreach (var message in result)
            {
                Console.WriteLine($"{message.Key} == {message.Value}");
            }
        }

    }
}
