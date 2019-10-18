namespace PdnMvc.Models
{
    public class Counter
    {
        public int Value { get; set; }

        public Counter()
        {
            Value = 0;
        }

        public void Increment()
        {
            Value++;
        }
    }
}