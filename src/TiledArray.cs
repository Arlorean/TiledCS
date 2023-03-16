namespace TiledCS {
    /// <summary>
    /// Two dimensional array with non-zero upper and lower bounds.
    /// Unity WebGL doesn't support this with the default .NET array.
    /// </summary>
    public class TiledArray<T> {
        int minX;
        int minY;
        int width;
        int height;
        T[,] array;

        public TiledArray(int minX, int minY, int width, int height) {
            this.minX = minX;
            this.minY = minY;
            this.width = width;
            this.height = height;
            array = new T[width, height];
        }

        public T this[int x, int y] {
            get => array[x-minX, y-minY];
            set => array[x-minX, y-minY] = value;
        }

        public int GetLowerBound(int dimension) {
            return dimension == 0 ? minX : minY;
        }

        public int GetUpperBound(int dimension) {
            return GetLowerBound(dimension)+GetLength(dimension)-1;
        }

        public int GetLength(int dimension) {
            return dimension == 0 ? width : height;
        }

        public int Length => width;
    }
}