namespace SpongeCase
{
    public class SpongeCaser
    {
        public static string ConvertToSpongeCase(string input)
        {
            //Counter to keep track of each normal letter [A-Z][a-z] that was found
            var normalCharacterCounter = 0;

            var convertedStringToBuild = "";

            for (var i = 0; i < input.Length; i++)
            {
                var currentCharacter = input[i];

                if(currentCharacter != ' ')
                    normalCharacterCounter++;

                if(normalCharacterCounter % 2 == 0){
                    convertedStringToBuild += input[i].ToString().ToUpper();
                }
                else {
                    convertedStringToBuild += input[i].ToString().ToLower();
                }
            }
            return convertedStringToBuild;
        }
    }
}