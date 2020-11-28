// RADIX SORT (CƠ SỐ)
static void RadixSort(int[] arr){
            int i, j;
            int n = arr.Length;
            int[] tmp = new int[n];
            for (int shift = 31; shift > -1; --shift){
                j = 0;
                for (i = 0; i < n; ++i){
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, n - j, j);
            }
}
