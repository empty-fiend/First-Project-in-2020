public interface ICharacter
{
    bool Grounded();
    void Walk();
    void Jump();
    void DealDamage();
    void GetDamage();
    void Die();
}