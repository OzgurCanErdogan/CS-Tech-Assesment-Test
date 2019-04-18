using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStechAssignment
{
    class GuessGame
    {
        List<int> rangeList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> gameNumber = new List<int>();
        List<int> userGuess = new List<int>();
        int plus = 0;
        int negative = 0;
        int roundNumber = 0;
        string guess;

        public int GetPlus() 
        {
            return plus;
        }
        public int GetRound()
        {
            return roundNumber;
        }
        public string GetGuess()
        {
            return guess;
        }

        public void SetGuess(string userGuess) // kullanıcının tahmin ettiği sayıyı kaydedip bunu rakamlarına ayırmak üzere methoda yolluyor.
        {
            guess = userGuess;
            this.userGuess = ConvertToList(guess);
        }
        public void SetGameNumber()
        {
            rangeList = ShuffleInitialList(rangeList);
            gameNumber = SelectNumber(rangeList);
        }

        public List<int> ShuffleInitialList(List<int> list) //her seferinde farklı bir sayı geldiğini doğrulamak üzere (0,1,2,3,4,5,6,7,8,9) setini karıştırıyor
        {
            List<int> resultList = new List<int>();
            Random r = new Random();
            int randomIndex = 0;
            while (list.Count > 0)
            {
                randomIndex = r.Next(0, list.Count);
                resultList.Add(list[randomIndex]);
                list.RemoveAt(randomIndex);
            }
            return resultList;
        }

        public List<int> SelectNumber(List<int> list) //bilgisayarın kullanıcının tahmin etmesi için sayıyı yarattığı method
        {
            List<int> resultList = new List<int>();
            Random r = new Random(); //karıştırılan listeden random sayı seçiliyor
            int randomIndex = 0;
            bool firstZeroChecker = true;
            for (int i = 0; i < 4; i++)
            {
                randomIndex = r.Next(0, list.Count);
                if (i == 0 && firstZeroChecker) //sayıdaki ilk rakamın 0 olmaması için kontrol mekanizması
                {
                    while (list[randomIndex] == 0)
                    {
                        randomIndex = r.Next(0, list.Count);
                    }
                    firstZeroChecker = false;
                }

                resultList.Add(list[randomIndex]); //sayıyı rakamlar halinde listeye ekliyor
                list.RemoveAt(randomIndex);
            }
            return resultList;
        }

        public Boolean numberChecker(List<int> userGuess) //girilen sayının rakamlarının farklı olup olmadığını kontrol ediyor
        {
            for (int i = 0; i < 4; i++)
            {
                int occurs = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (userGuess[i] == userGuess[j])
                        occurs++;
                }
                if (occurs > 1)
                    return false;
            }
            return true;
        }

        public List<int> ConvertToList(string guess) //kullanıcının tahmin ettiği sayıyının rakamlarını birer birer listeye ekliyor
        {
            List<int> result = new List<int>();
            var chars = guess.ToCharArray();
            for (int i = 0; i < guess.Length; i++)
            {
                result.Add(Convert.ToInt32(chars[i].ToString()));
            }
            return result;
        }

        public int GetNegatives(List<int> gameNumber, List<int> userGuess)//kullanıcının tahmin ettiği sayıyı, bilgisayarın tahmin ettiği sayı ile kıyaslıyor.
        {
            int result = 0;
            for (int i = 0; i < userGuess.Count; i++)
            {
                if (gameNumber.Contains(userGuess[i]))//eğer aynı rakamları içeriyorsa eksi sayısını arttırıyor
                {
                    result++;
                }
            }
            return result;
        }

        public int GetPositives(List<int> gameNumber, List<int> userGuess)//kullanıcının tahmin ettiği sayıyı, bilgisayarın tahmin ettiği sayı ile kıyaslıyor.
        {
            int result = 0;
            for (int i = 0; i < userGuess.Count; i++)
            {
                if (gameNumber[i] == userGuess[i])//eğer rakamların konumları da doğru ise artı sayısını arttırıyor
                {
                    result++;
                }
            }
            return result;
        }

        public string UserTriesToGuess()
        { 

            if (guess.Length != 4 || !numberChecker(userGuess))
            {
                return "Hatalı giriş yaptınız. Tekrar giriniz.";
            }
            else
            {
                plus = GetPositives(gameNumber, userGuess); //artı sayısı kayıt ediliyor
                negative = GetNegatives(gameNumber, userGuess) - plus; //eksi sayısı kayıt ediliyor
                roundNumber++;
                return "Tahmin ettiğiniz sayının ("+ guess+") sonuçları: +" + plus + " ve -" + negative;
            }
        }

    }
}
