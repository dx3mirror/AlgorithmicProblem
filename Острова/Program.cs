using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Острова
{
    class Program
    {
        public interface IStrategy
        {
            int CountIslands(int[,] grid);
        }
        public class DFSStrategy : IStrategy
        {
            public int CountIslands(int[,] grid)
            {
                return 0;
                // реализация алгоритма подсчета островов с помощью Depth First Search (DFS)
            }
        }

        public class BFSStrategy : IStrategy
        {
            public int CountIslands(int[,] grid)
            {
                return 0;
                // реализация алгоритма подсчета островов с помощью Breadth First Search (BFS)
            }
        }
        public class IslandCounter
        {
            private IStrategy _strategy;

            public IslandCounter(IStrategy strategy)
            {
                _strategy = strategy;
            }

            public int CountIslands(int[,] grid)
            {
                return _strategy.CountIslands(grid);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры двумерного массива:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] grid = new int[m, n];

            Console.WriteLine("Введите элементы двумерного массива:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grid[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Выберите стратегию подсчета островов (1 - DFS, 2 - BFS):");
            int strategyChoice = int.Parse(Console.ReadLine());

            IStrategy strategy;

            if (strategyChoice == 1)
            {
                strategy = new DFSStrategy();
            }
            else if (strategyChoice == 2)
            {
                strategy = new BFSStrategy();
            }
            else
            {
                Console.WriteLine("Некорректный выбор стратегии.");
                return;
            }

            IslandCounter counter = new IslandCounter(strategy);
            int islandCount = counter.CountIslands(grid);

            Console.WriteLine("Количество островов: " + islandCount);
        }
    }
}