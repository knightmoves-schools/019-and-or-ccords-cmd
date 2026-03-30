namespace knightmoves;
public class Verifier
{
public string taxable(state, taxExempt) {
  if (state == 'IA' && taxExempt == false) {
    return "is taxable";
  }};
public string isVehicle(hasWheels, canFly, canSwim) {
  if (hasWheels == true || canFly == true || canSwim == true) {
    return "is vehicle";
  }};
}
