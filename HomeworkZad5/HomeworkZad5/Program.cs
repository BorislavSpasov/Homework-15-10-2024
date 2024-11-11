Console.Write("Please input what you want to reverse: ");
string userWord = Console.ReadLine();

int wordLength = userWord.Length;

for (int i = 0; i < userWord.Length; i++)
{
    wordLength -= 1;
    Console.Write(userWord[wordLength]);
}
