using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rating
{
    public class num_rat
    {
       public int N, n2,n3,n4,n5;
        List<int> array;
        public num_rat()
        {
            N = 0;
            n2 = 0; n3 = 0;n4 = 0;n5 = 0;
            array = new List<int>();
        }
        public void count()
        {
            int temp;
            foreach (int val in array.Distinct())
            {
                temp = array.Where(x => x == val).Count();
                switch (val)
                {
                    case 2: n2 = temp; break;
                    case 3: n3 = temp; break;
                    case 4: n4 = temp; break;
                    case 5: n5 = temp; break;
                }
                    
            }
        }
        public string read_string(string str,int M)
        {
            for(int i=0;i<str.Length;i++)
            {
                if(Char.IsDigit(str[i]))
                {
                    if (i+1 < str.Length)
                    {
                        if (Char.IsDigit(str[i + 1]))
                            return "Ошибка! Неверный формат чисел (разряды)!";
                    }
                    if (((int)char.GetNumericValue(str[i]) >= 2) && ((int)char.GetNumericValue(str[i]) <= 5))
                        array.Add((int)char.GetNumericValue(str[i]));
                    else return "Ошибка! Неверный формат оценок (значение)! ";
                }
            }
            N = array.Count;
            if (M != N)
                return "Ошибка! Неверное количество оценок!";
            count();
            return "Двоек - "+n2+"\nТроек - "+n3+"\nЧетверок - "+n4+"\nПятерок - "+n5;
        }

    }
}
