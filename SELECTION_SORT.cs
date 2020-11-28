// SELECTION SORT (SẮP XẾP CHỌN)
static int[] SelectionSort(int[] a){
            int n = a.Length;
            for (int i = 0; i < n; i++){
                // Tim vi tri min 
                int minIndex = i;
                for (int j = i; j < n; j++){
                    if (a[minIndex] > a[j])
                        minIndex = j;
                }
                // Hoan vi vi tri i
                if (minIndex != i){
                    int temp = a[minIndex];
                    a[minIndex] = a[i];
                    a[i] = temp;
                }
            }
            return a;
}
