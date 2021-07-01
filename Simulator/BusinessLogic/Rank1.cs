using System;

namespace Simulator.BusinessLogic
{
    public struct Rank
    {
        public int Id;
        public string Name;

        public Rank(string name)
        {
            Name = name;

            switch (name)
            {
                case "Первый курс": Id = 1; break;
                case "Второй курс": Id = 2; break;
                case "Третий курс": Id = 3; break;
                case "Четвертый курс": Id = 4; break;
                case "Помошник менеджера отеля": Id = 5; break;
                case "Менеджера отеля": Id = 6; break;
                default: throw new ArgumentException($"Нет ранга {name}");
            }
        }

        public static string GetRankNameById(int id)
        {
            switch (id)
            {
                case 1: return "Первый курс";
                case 2: return "Второй курс";
                case 3: return "Третий курс";
                case 4: return "Четвертый курс";
                case 5: return "Помошник менеджера отеля";
                case 6: return "Менеджера отеля";
                default: throw new ArgumentException($"Нет ранга с id {id}");
            }
        }
    }
}
