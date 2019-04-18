using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStechAssignment
{
    class GuessGamePc
    {
        List<int> numberSet = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Random r = new Random();
        int randomGuess = 0;
        int plus = 0;
        int negative = 0;
        int roundNumber = 0;


        public int GetRandomGuess()
        {
            return randomGuess;
        }
        public int GetRound()
        {
            return roundNumber;
        }
        public int GetPlus()
        {
            return plus;
        }
        public void SetPlusAndNegatives(int p, int n)
        {
            plus = p;
            negative = n;
        }

        public void SetNumberSet() //yaratışan 4536 farklı sayı listeye ekleniyor
        {
            numberSet = CreatePermutation(numberSet);
        }

        public List<int> CreatePermutation(List<int> list) //(0,1,2,3,4,5,6,7,8,9) listesinden 10un 4lü permütasyonları yaratılıyor
        { // recursion yazamadım. Bu yüzden çok büyük bir runtime sahip O(n^4).
            List<int> result = new List<int>();
            string tempNumberString = ""; //her rakam bu stringe ekleniyor. Çünkü basamakları farklı bir sayı yartırken, bunun kontrolünde bazı problemler yaşadım.
            int tempNumber = 0;             //bu yüzden string.contains i kullanarak daha basit bir çözüm kullandım
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 0)//ilk sayının 0 olmaması kontrol ediliyor
                {
                    tempNumberString = String.Concat(tempNumberString, list[i].ToString()); //her rakam stringe ekleniyor
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (!tempNumberString.Contains(list[j].ToString()))//aynı rakamların olmaması için kontrol noktası
                        {
                            tempNumberString = String.Concat(tempNumberString, list[j].ToString());//her rakam stringe ekleniyor
                            for (int k = 0; k < list.Count; k++)
                            {
                                if (!tempNumberString.Contains(list[k].ToString()))//aynı rakamların olmaması için kontrol noktası
                                {
                                    tempNumberString = String.Concat(tempNumberString, list[k].ToString());//her rakam stringe ekleniyor
                                    for (int m = 0; m < list.Count; m++)
                                    {
                                        if (!tempNumberString.Contains(list[m].ToString()))//aynı rakamların olmaması için kontrol noktası
                                        {
                                            tempNumberString = String.Concat(tempNumberString, list[m].ToString());//her rakam stringe ekleniyor
                                            result.Add(Convert.ToInt32(tempNumberString));//string tekrar sayıya çevrilip listeye ekleniyor
                                            tempNumberString = tempNumberString.Remove(3);//yeni sayı için son eklenen rakam siliniyor
                                        }

                                    }
                                    tempNumberString = tempNumberString.Remove(2);//yeni sayı için son eklenen rakam siliniyor
                                }
                            }
                            tempNumberString = tempNumberString.Remove(1);//yeni sayı için son eklenen rakam siliniyor
                        }
                    }
                    tempNumberString = tempNumberString.Remove(0);//yeni sayı için son eklenen rakam siliniyor
                }

            }
            return result;
        }
        public void RemoveList(List<int> list, int guess, int plus, int neg)//oyunun tahmin kısmı
        {
            //burada kullanıcının girdiği + ve - sayılarına göre, bilgisayarın tahmin ettiği son sayı ile aynı + ve - değerlerine sahip sayılar tutuluyor
            //geri kalan bütün sayılar listeden siliniyor

            int one, ten, hundred, thousand;
            //sayı rakamlarına ayrılıyor
            one = guess % 10;
            ten = ((guess % 100) - one) / 10;
            hundred = ((guess % 1000) - one - (ten * 10)) / 100;
            thousand = (guess - (guess % 1000)) / 1000;

            for (int i = 0; i < list.Count; i++)
            {
                int tempPlus = 0;
                int tempNeg = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        int listThousand = (list[i] - (list[i] % 1000)) / 1000;
                        if (thousand == listThousand)//rakamların konumu aynı ise + sayısı artıyor
                        {
                            tempPlus++; 
                        }
                        if (list[i].ToString().Contains(thousand.ToString()))//aynı rakamları içeriyorsa - sayısı arttırılıyor
                        {
                            tempNeg++;
                        }
                    }
                    else if (j == 1)
                    {
                        int listHundred = ((list[i] % 1000) - (list[i] % 100)) / 100;
                        if (hundred == listHundred)//rakamların konumu aynı ise + sayısı artıyor
                        {
                            tempPlus++;
                        }
                        if (list[i].ToString().Contains(hundred.ToString()))//aynı rakamları içeriyorsa - sayısı arttırılıyor
                        {
                            tempNeg++;
                        }
                    }
                    else if (j == 2)
                    {
                        int listTen = ((list[i] % 100) - (list[i] % 10)) / 10;
                        if (ten == listTen)//rakamların konumu aynı ise + sayısı artıyor
                        {
                            tempPlus++;
                        }
                        if (list[i].ToString().Contains(ten.ToString()))//aynı rakamları içeriyorsa - sayısı arttırılıyor
                        {
                            tempNeg++;
                        }
                    }
                    else
                    {
                        int listOne = list[i] % 10;
                        if (one == listOne)//rakamların konumu aynı ise + sayısı artıyor
                        {
                            tempPlus++;
                        }
                        if (list[i].ToString().Contains(one.ToString()))//aynı rakamları içeriyorsa - sayısı arttırılıyor
                        {
                            tempNeg++;
                        }
                    }
                }
                tempNeg = tempNeg - tempPlus; //eksi sayısı set ediliyor
                if ((tempPlus != plus) || (tempNeg != neg)) //aynı + ve - sayısını içermeyen sayılar listeden siliniyor.
                    list.RemoveAt(i);

            }

        }
        public void PlayGame()
        {
            RemoveList(numberSet, randomGuess, plus, negative);
        }
        public string PcTriesToGuees()
        {
            
            if(plus == 4)
            {
                return "Bilgisayar Kazandı!!!";
            }
            else
            {
                roundNumber++;
                randomGuess = numberSet[r.Next(0, numberSet.Count - 1)];//kalan listeden farklı sayı seçiliyor
                return "Bilgisayarın tahmin ettiği sayı: " + randomGuess + "  +'ların ve -'lerin sayısını giriniz!";
                
            }

            
        }


    }
}
