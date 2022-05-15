using System;

namespace CourseWork
{
    class Matrix
    {
        // массив, который хранит в себе матрицу
        private double[,] matrix;
        // конструктор, который создает матрицу на основе двумерного массива
        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }
        // конструктор, который создает матрицу по параметрам
        public Matrix(int row, int column)
        {
            this.matrix = new double[row, column];
        }
        // вспомогательная функция поиска минора, на вход: матрица и координаты элемента, для которого ищем
        private static double[,] GetMinor(double[,] matrix, int p, int q)
        {
            int n = matrix.GetLength(0);
            int i = 0, j = 0;
            double[,] temp = new double[n - 1, n - 1];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    // "вычеркиваем" столбец и строку, на которых находится элемент
                    if (row != p && col != q)
                    {
                        temp[i, j++] = matrix[row, col];
                        // если доходим до границы, переходим на новую строку
                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
            return temp;
        }
        // рекурсивная функция поиска определителя, на вход матрица
        public double findDet(double[,] matrix)
        {
            double result = 0;
            int n = matrix.GetLength(0);
            // если размер матрицы 1, то определитель равен этому элемнту
            if (n == 1)
            {
                return matrix[0, 0];
            }
            // знак
            int sign = 1;
            // раскрываем определитель по первому ряду
            for (int i = 0; i < n; i++)
            {
                // получаем минор с помощью вспомогательной функции
                double[,] tempMatrix = GetMinor(matrix, 0, i);
                // к результату прибавляем определитель минора, умноженный на значение элемента и на соотв. знак
                result += sign * matrix[0, i] * findDet(tempMatrix);
                sign = -sign;
            }
            return result;
        }
        // геттер для матрицы
        public double[,] getMatrix()
        {
            return matrix;
        }
        // функция для траспонирования квадратной матрицы
        private static double[,] transpose(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] result = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // записываем столбцы в ряды
                    result[i, j] = matrix[j, i];
                }
            }
            return result;
        }
        // Функция для нахождения обратной матрицы
        public double[,] inverse(double[,] input)
        {
            // находим определитель исходной матрицы, если он равен 0 - выходим из метода
            double determinant = findDet(input);
            if (determinant == 0)
            {
                return null;
            }
            int n = input.GetLength(0);
            // создаем матрицу для записи результата
            double[,] result = new double[n, n];
            // коэффициент, на который будут домножаться элементы
            double coefficient = 1 / determinant;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // находим матрицу алгебраических дополнений
                    result[i, j] = coefficient * findDet(GetMinor(input, i, j));
                }
            }
            // транспонируем матрицу
            result = transpose(result);
            // меняем знаки в нужных позициях
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] *= Math.Pow(-1, i + j);
                }
            }
            return result;
        }
        // Функция для умножения матриц
        public double[,] multiply(double[,] first, double[,] second)
        {
            // Задаем размерности результирующей матрицы и создаем её
            int row = first.GetLength(0);
            int column = second.GetLength(1);
            double[,] res = new double[row, column];
            // Умножаем по правилам линейной алгебры
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    double tempElement = 0;
                    for (int k = 0; k < second.GetLength(0); k++)
                    {
                        tempElement += first[i, k] * second[k, j];
                    }
                    res[i, j] = tempElement;
                }
            }
            return res;
        }
    }
}
