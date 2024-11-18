using PLC;

namespace LocalApp
{
    public struct UserFBin
    {
        public int num1;
        public int num2;
        public int num3;
        public bool 出料口检测;
    }
    public struct UserFBout
    {
        public bool a;
        public bool b;
        public bool c;
        public bool d;
    }

    class UserFB : PlcFBEx
    {
        IPM pm;
        public ref UserFBin x => ref pm.MemRef<UserFBin>(100);
        public ref UserFBout y => ref pm.MemRef<UserFBout>(200);

        public UserFB() : base("用户自定义功能块", 1000) { }

        // 逻辑初始化.
        public override void Init(IPM pm)
        {
            this.pm = pm;

            this.AddIn(ref x);
            this.AddOut(ref y);
        }

        // 周期扫描. 执行逻辑
        public override void Scan(IPM pm)
        {
            y.a = !y.a;
            y.b = pm.SR.P_1;
            y.c = !pm.Delay(y.d, 200);
            y.d = pm.Delay(y.c, 200);

            x.num1++;
            if(pm.P(y.b)) x.num2++;
        }
    }
}
