namespace Assets.Scripts.Magic
{
    public class StartBGMMagic:BaseMagic
    {
        protected override void activate()
        {
            
            PlaySE(1);
            PlayVFX(2);
            GetBGMManager().Play();
        }
    }
}