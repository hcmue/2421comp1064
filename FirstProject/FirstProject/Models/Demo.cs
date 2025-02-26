namespace FirstProject.Models
{
    public class Demo
    {
        public int A()
        {
            Thread.Sleep(2000);
            return new Random().Next();
        }
        public string B()
        {
            Thread.Sleep(5000);
            return "HELLO";
        }
        public void C() { Thread.Sleep(3000); }

        public async Task<int> AsyncA()
        {
            await Task.Delay(2000);
            return new Random().Next();
        }
        public async Task<string> AsyncB()
        {
            await Task.Delay(5000);
            return "AAA";
        }
        public async Task AsyncC()
        {
            await Task.Delay(3000);
        }
    }
}
