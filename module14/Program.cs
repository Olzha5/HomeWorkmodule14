using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание игры с заданными именами игроков
            string[] playerNames = { "Игрок 1", "Игрок 2" };
            Game game = new Game(playerNames);

            // Запуск игры
            game.PlayGame();

            // Здесь также можно добавить дополнительный код, например,
            // для повторной игры или для вывода статистики игр.
        }
    }
}
