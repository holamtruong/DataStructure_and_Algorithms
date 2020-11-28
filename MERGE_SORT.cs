// MERGE SORT - (SẮP XẾP TRỘN)
void Sort(int[] A, int l, int r){
        if (l < r){
            int m = (l + r) / 2;
            Sort(A, l, m);
            Sort(A, m + 1, r);
            Merge(A, l, m, r);
        }
}
void Merge(int[]A,int l,int m,int r){
        int n1 = m - l + 1;
        int n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;
        for (i = 0; i < n1; ++i)
            L[i] = A[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = A[m + 1 + j];
        i = 0;
        j = 0;
        int k = l;
        while (i < n1 && j < n2){
            if (L[i] <= R[j]){
                A[k] = L[i];
                i++;
            }else{
                A[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < n1){
            A[k] = L[i];
            i++;
            k++;}
        while (j < n2){
            A[k] = R[j];
            j++;
            k++;
        }
}
