void exer38() {

    Random rnd = new Random();
    int[] array = new int[rnd.Next(2, 11)];

    int min = 100, 
        max = 0;

    for (int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(1, 100);
        if (array[i] > max) {
            max = array[i];
        }
        if (array[i] < min) {
            min = array[i];
        }
    }
    
    Console.WriteLine("Полученный массив:" + "[{0}]", string.Join(", ", array));
    Console.WriteLine("Разница между максимальным и минимальным числом:" + (max - min));
}

exer38();
