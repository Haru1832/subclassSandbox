namespace Assets.Scripts.Magic
{
    public class StopBGMMagic:BaseMagic
    {
        protected override void activate()
        {
            //意味のある仕様じゃないけど試しに１０秒未満なら止められない
            if (GetBGMManager().GetcurrentBGMTime() < 10) return;

            
            PlaySE(1);
            PlayVFX(1);
            GetBGMManager().Stop();
        }
    }
}