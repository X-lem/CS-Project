public class Player {

  private double _maxHealth;
  private double _health;
  private int _coins = 0;


  private Weapon _equiped = null;
  private Item _pocket = null;

  public Player() {

  }

  // Weapon handle
  public void GiveWeapon(Weapon weapon) {
    _equiped = weapon;
  }
  public void DropWeapon() {
    _equiped = null;
  }

  // Item handle
  public void GiveItem(Item item) {
    _pocket = item;
  }
  public void DropItem() {
    _pocket = null;
  }

  // Coin handle
  public void AddCoins(int amount) {
    _coins += amount;
  }

  public bool haveEnoughCoins(int amount) {
    return (_coins - amount >= 0);
  }

  public void SpendCoins(int amount) {
    _coins -= amount;
  }

  public void Attack() {
    if (_equiped != null)
      _equiped.UseWeapon();
  }

  public void TakeDamage(double damage) {
    _health -= damage;

    if (_health <= 0) {
      // die
    }
  }

  // Increase or decrease max health with a positive or negative number respectively
  public void AdjustMaxHealth(double amount) {
    _maxHealth += amount;
  }
}