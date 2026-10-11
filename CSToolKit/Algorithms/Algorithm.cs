namespace CSToolKit;

public class Algorithm
{
    public int[] InsertionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int key = array[i]; //key value to be sorted
            int j = i - 1; //allows first index to be checked

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j]; //shifts value at index j one index to the right
                j -= 1; //moves j one index to the left
            }
            array[j + 1] = key; //adds key to index j + 1
        }

        return array;
    }
}