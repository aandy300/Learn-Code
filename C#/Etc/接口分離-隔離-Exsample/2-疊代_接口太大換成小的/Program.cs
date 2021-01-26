// 接口隔離exsample2
// 只讀 只能被疊代 不能往裡面添加 不能清除不能刪除的
// 調用者絕不多要,傳進來的都是需要的不應該有用不到的
using System;
using System.Collections;

namespace _2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums1 = {1, 3, 5, 7, 9};
            #region  獨立 隱藏
            Console.WriteLine("Hello World!");
            ArrayList nums2 = new ArrayList{1, 2, 3, 4, 5};
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            #endregion
            
            #region foreach()背後 拿IEnumerator 把Current 疊代一遍
            var nums3 = new ReadOnlyCollection(nums1);
            Console.WriteLine("foreach() 以下開始:");
            foreach(var line in nums3){
                Console.WriteLine("nums3 該行 內容:" + line);
            }
            Console.WriteLine("-----分隔線-----");
            Console.WriteLine("-----以下為Sum(num3)-----");
            Console.WriteLine(Sum(nums3));  //等於在做一次上面的foreach() 
            #endregion
        }
        #region 獨立 Sum()
        // ICollection 太大 換成 IEnumerable
        // static int Sum(ICollection nums){
        static int Sum(IEnumerable nums){
            // nums.
            int sum = 0;
            foreach(var n in nums){
                sum += (int)n;
            }
            return sum;
        }
        #endregion

        class ReadOnlyCollection : IEnumerable{
            
            private int[] _array;
            
            // 構造 進來的num1 = 這class裡的 _array
            public ReadOnlyCollection(int[] array){
                Console.WriteLine("ReadOnlyCollection 構造");
                _array = array;
            }

            public IEnumerator GetEnumerator(){
                Console.WriteLine("foreach 01 IEnumerator GetEnumerator()");
                // this = var roc = new ReadOnlyCollection(nums1);
                return new Enumerator(this);
            }
            
            public class Enumerator:IEnumerator{
                private ReadOnlyCollection _collection;
                private int _index;
                
                // 結構
                public Enumerator(ReadOnlyCollection collection){
                    _collection = collection;
                    _index = -1;
                    Console.WriteLine("foreach 02 Enumerator()");
                    Console.WriteLine("_collection: " + collection._array[0]);
                    Console.WriteLine("_head: " + _index);
                }
                public bool MoveNext(){
                    if(++_index < _collection._array.Length){
                        Console.WriteLine("foreach 03 bool MoveNext() TRUE");
                        Console.WriteLine("movenext _head" + _index);
                        return true;
                    }else{
                        Console.WriteLine("foreach 03 bool MoveNext() FALSE");
                        return false;
                    }
                }
                public void Reset(){
                    Console.WriteLine("foreach Reset() TRUE");
                    _index = -1;
                }
                public Object Current{
                    get{
                        // o = _array裡的內容
                        object o = _collection._array[_index];
                        Console.WriteLine("foreach 04 Object Current");
                        Console.WriteLine("OBJ _head = " + _index);
                        Console.WriteLine("OBJ o = " + o);
                        return o;
                    }
                }

            }
        }
    }
}