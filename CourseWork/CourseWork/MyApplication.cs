using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MyApplication : Form
    {
        // Конструктор, который инициализирует компонент
        public MyApplication()
        {
            InitializeComponent();
        }
        // вспомогательная функция для создания матриц
        // вход: количество строк и столбцов, элемент, откуда будем считывать значения
        // префикс для идентификации, откуда именно брать информацию
        private Matrix createMatrix(int row, int column, Panel panel, string prefix ="")
        {
            // создание двумерного массива чисел с плавающей точкой
            double[,] matrix = new double[row, column];
            // в цикле проходимся по всему массиву и считываем значения элементов с формы
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    // name хранит имя объекта, с которого будем читать
                    string name = prefix + i.ToString() + " " + j.ToString();
                    // если введенная информация - число, то записываем это значение в массив
                    bool isNum = double.TryParse(panel.Controls[name].Text, out double temp);
                    if (isNum)
                    {
                        matrix[i, j] = temp;
                    }
                }
            }
            // создает матрицу на основе массива и возвращаем её
            Matrix result = new Matrix(matrix);
            return result;
        }
        // вспомогательный метод для создания окон, куда вводятся значения элементов матриц
        // вход: количество строк и колонок, начальная позиция, логическое значение, можно ли изменять элементы
        // и префикс, он во всей программе используется по одному принципу
        private TextBox[,] createTextBoxes(int row, int column, int startX = 22, int startY = 22,
            bool isReadOnly = false, string prefix = "")
        {
            TextBox[,] matrix = new TextBox[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    // создаем окно для ввода текста с параметрами
                    matrix[i, j] = new TextBox()
                    {
                        // имя "prefix0 0" - префикс сменяется, а в цифрах положение номер элемента в матрице
                        Name = prefix + i.ToString() + " " + j.ToString(),
                        // можно выводить несколько строк, для красоты
                        Multiline = true,
                        // выравнивание текста по центру
                        TextAlign = HorizontalAlignment.Center,
                        // установка размера 45 на 45 пикселей
                        Size = new Size(45, 45),
                        // настройка шрифта и его размера
                        Font = new Font("Microsoft Sans Serif", 16F),
                        // положение на странице
                        Location = new Point(45 * j + startX, 45 * i + startY),
                        // можно ли изменять содержимое поля
                        ReadOnly = isReadOnly,
                    };
                }
            }
            return matrix;
        }
        // служебная функция добавления матрицы на элемент
        // вход: панель, на которую будем выводить элементы и матрица окон для текста, которые выводим
        private void paintMatrix(Panel panel, TextBox[,] matrix)
        {
            // в цикле добавляем все элементы по очереди, положение зафиксировано при их создании
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    panel.Controls.Add(matrix[i, j]);
                }
            }
        }
        // функция для измения цвета окон результата умножения, захотелось сделать для красоты
        private void paintResult(TextBox[,] matrix)
        {
            // объявляем цвет, который будем устанавливать с помощью его RGB кода
            Color color = Color.FromArgb(188, 184, 206);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // красим элемент
                    matrix[i, j].BackColor = color;
                }
            }
        }
        // обработка события кнопки установки размера матриц на первой вкладке
        private void set_size_mult(object sender, EventArgs e)
        {
            // Обработка исключений, если введем в поле размерности что-то, кроме целого числа
            try
            {
                // Считываем значения с окон размерностей
                int row_first = Int32.Parse(tb_row_first.Text);
                int column_first = Int32.Parse(tb_column_first.Text);
                int row_second = Int32.Parse(tb_row_second.Text);
                int column_second = Int32.Parse(tb_column_second.Text);
                // если всё введено корректно, создаем матрицы по введенным параметрам
                if (row_first > 0 && column_first > 0 && row_second > 0 && column_second > 0
                    && row_second == column_first)
                {
                    // очищаем панель от предыдущих элементов
                    p_matrix1.Controls.Clear();
                    // создание первой, второй и результирующей матриц и их вывод
                    TextBox[,] matrix1 = createTextBoxes(row_first, column_first, prefix:"first");
                    paintMatrix(p_matrix1, matrix1);
                    // изменение позиции, начиная с которой располагаются матрицы, чтобы они не были друг на друге
                    int secondPos = 45 * (column_first + 1);
                    TextBox[,] matrix2 = createTextBoxes(row_second, column_second, secondPos, prefix:"second");
                    paintMatrix(p_matrix1, matrix2);
                    int resPos = 45 * (column_first + column_second + 2);
                    TextBox[,] result = createTextBoxes(row_first, column_second, resPos, 22, true, prefix: "result");
                    // изменение цвета окна результата
                    paintResult(result);
                    paintMatrix(p_matrix1, result);
                }
            }
            // если некорректно ввели размерность матрицы, ничего не делаем
            catch (FormatException ex){ }
        }
        // обработка события кнопки умножения матриц друг на друга
        private void multiply(object sender, EventArgs e)
        {
            // считывание размеров
            int row_first = Int32.Parse(tb_row_first.Text);
            int column_first = Int32.Parse(tb_column_first.Text);
            int row_second = Int32.Parse(tb_row_second.Text);
            int column_second = Int32.Parse(tb_column_second.Text); 
            // создание первой и второй матрицы на основе ввода 
            Matrix first = createMatrix(row_first, column_first, p_matrix1, "first");
            Matrix second = createMatrix(row_second, column_second, p_matrix1, "second");
            // создание результирующей матрицы с помощью метода, который умножает их
            double[,] result = first.multiply(first.getMatrix(), second.getMatrix());
            // вывод содержимого результата на соответствующие окна
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    string name = "result" + i.ToString() + " " + j.ToString();
                    p_matrix1.Controls[name].Text = result[i, j].ToString();
                }
            }
        }
        // обработка события установки количества неизвестных в уравнении
        private void set_x(object sender, EventArgs e)
        {
            // считываем количество неизвестных в x_number
            bool is_success = int.TryParse(tb_x_number.Text, out int x_number);
            if (!is_success || x_number < 1) return;
            // создание матрицы коэффициентов с помощью вспомогательной функции
            TextBox[,] matrix = createTextBoxes(x_number, x_number, prefix: "A");
            // очистка панели
            p_matrix3.Controls.Clear();
            for (int i = 0; i < x_number; i++)
            {
                for (int j = 0; j < x_number; j++)
                {
                    // добавление на панель коэффициентов
                    p_matrix3.Controls.Add(matrix[i, j]);
                }
                // создание и добавление на панель окна для неизвестных
                p_matrix3.Controls.Add(new TextBox()
                {
                    Name = "x" + i,
                    Multiline = true,
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Microsoft Sans Serif", 16F),
                    Size = new Size(45, 45),
                    Location = new Point(45 * x_number + 45, 45 * i+22),
                    Text = "x" + i,
                    ReadOnly = true,
                    // установка цвета фона
                    BackColor = Color.FromArgb(188,184,206),
                }) ;
                // создание и добавление на панель окна для значений
                p_matrix3.Controls.Add(new TextBox()
                {
                    Name = "B" + i + " 0",
                    Size = new Size(45, 45),
                    Multiline = true,
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Microsoft Sans Serif", 16F),
                    Location = new Point(45 * x_number + 112, 45 * i+22),
                });
            }
        }
        // Обработка события кнопки решения уравнения
        private void solution(object sender, EventArgs e)
        {
            // считываем количество переменных
            bool is_success = int.TryParse(tb_x_number.Text, out int size);
            if (!is_success || size < 1) return;
            // создаем матрицы коэффициентов и значений, одна размером n х n переменных, другая столбец из n строк
            Matrix a = createMatrix(size, size, p_matrix3, "A");
            Matrix b = createMatrix(size, 1, p_matrix3, "B");
            // Находим обратную матрицу с помощью метода класса Matrix
            double[,] inverseA = a.inverse(a.getMatrix());
            // Находим ответы, умножив обратную матрицу на матрицу коэффициентов с помощью метода
            double[,] result = a.multiply(inverseA, b.getMatrix());
            // Выводим результат в соответствующие окна
            for(int i = 0; i<size; i++)
            {
                string name = "x" + i;
                p_matrix3.Controls[name].Text = result[i, 0].ToString();
            }
        }
        // Обработка события для кнопки установки размера матрицы для поиска определителя
        private void set_size(object sender, EventArgs e)
        {
            // считываем размер
            bool is_success = int.TryParse(tb_input_size.Text, out int size);
            if (!is_success || size < 1) return;
            // создаем матрицу окон для текста с помощью вспомогательной функции
            TextBox[,] matrix = createTextBoxes(size, size);
            // очищаем панель от предыдущих элементов
            p_matrix2.Controls.Clear();
            // выводим созданную матрицу на панель
            paintMatrix(p_matrix2, matrix);
        }

        // Обработка события для кнопки "найти определитель"
        private void find_det(object sender, EventArgs e)
        {
            // забираем размер матрицы из соседнего поля
            bool is_success = int.TryParse(tb_input_size.Text, out int size);
            // создаем матрицу с помощью функции, определенной выше
            Matrix m = createMatrix(size, size, p_matrix2);
            // находим определитель с помощью метода объекта класса Matrix
            double det = m.findDet(m.getMatrix());
            // Выводим результат на соседнее окно
            tb_det.Text = det.ToString();
        }

        // Запрещаем ввод каких-либо символов, кроме цифр, в окна размерностей
        private void tb_input_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            // number - нажатая клавиша
            char number = e.KeyChar;
            // если нажали не клавишу или не бэкспейс, то пропускаем этот символ
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tb_x_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)  
            {
                e.Handled = true;
            }
        }
        private void tb_row_first_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
        private void tb_column_first_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
        private void tb_row_second_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
        private void tb_column_second_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }  
    }
}
