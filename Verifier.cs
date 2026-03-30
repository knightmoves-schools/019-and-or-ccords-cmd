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
/*should create a method named Taxable that takes two parameters state and taxExempt and returns the string "is taxable" if the state is IA and taxExempt is false
should return an empty string ("") from Taxable if the state is IA and taxExempt is true
should return an empty string ("") from Taxable if the state is FL and taxExempt is false
should create a method named IsVehicle that takes three parameters hasWheels, canFly, canSwim and returns the string "is vehicle" if at least one of the three parameters evaluates to true
should return the string "is vehicle" from IsVehicle when hasWheels is true and canFly and canSwim are both false
should return the string "is vehicle" from IsVehicle when canFly is true and hasWheels and canSwim are both false
should return the string "is vehicle" from IsVehicle when canSwim is true and canFly and hasWheels are both false
should return the string "is vehicle" from IsVehicle when canSwim and canFly are both true and hasWheels is false
should return an empty string ("") from IsVehicle when hasWheels, canFly, and canSwim are all false*/ 
