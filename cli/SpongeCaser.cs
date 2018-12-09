using System.Text.RegularExpressions;

namespace SpongeCase
{
    public class SpongeCaser
    {
        public static string ConvertToSpongeCase(string input, bool startWithCapitalLetter = false)
        {
            var capitilizeCharacterFlag = !startWithCapitalLetter;

            var convertedStringToBuild = "";

            var specialCharacterRegex = new Regex("^[a-zA-Z]*$");

            for (var i = 0; i < input.Length; i++)
            {
                var currentCharacter = input[i].ToString();
                if (specialCharacterRegex.IsMatch(currentCharacter))
                {
                    capitilizeCharacterFlag = !capitilizeCharacterFlag;
                    if (capitilizeCharacterFlag)
                    {
                        convertedStringToBuild += currentCharacter.ToUpper();
                    }
                    else
                    {
                        convertedStringToBuild += currentCharacter.ToLower();
                    }
                }
                else {
                    convertedStringToBuild += currentCharacter;
                }
            }
            return convertedStringToBuild;
        }
    }
}