namespace knightmoves;
public class Verifier
{
public string Taxable(string state, bool taxExempt) {
  if (state == 'IA' && taxExempt == false) {
    return "is taxable";
  }}
public string IsVehicle(bool hasWheels, bool canFly, bool canSwim) {
  if (hasWheels == true || canFly == true || canSwim == true) {
    return "is vehicle";
  }}
}
