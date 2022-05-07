namespace Assets.Scripts.Magic
{
    public class FireMagic:BaseMagic
    {
        
        protected override void activate()
        {
            PlaySE(0);
            PlayVFX(0);
        }
    }
}