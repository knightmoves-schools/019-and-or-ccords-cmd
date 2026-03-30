namespace knightmoves;
public class Verifier
{
public string taxable(string state, bool taxExempt) {
  if (state == 'IA' && taxExempt == false) {
    return "is taxable";
  }}
public string isVehicle(bool hasWheels, bool canFly, bool canSwim) {
  if (hasWheels == true || canFly == true || canSwim == true) {
    return "is vehicle";
  }}
}
