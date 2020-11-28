// LINEAR SEARCH – SENTINEL (LÍNH CANH)
static int LinearSentinel (int[] A, int x){
            int n = A.Length;
            int[] B = new int[n + 1];
            Array.Copy(A, B, n);
            B[n] = x;
            int i = 0;
            while (B[i] != x)
                i++;
            if (i == n)
                return -1;
            return i;
}
