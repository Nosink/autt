
public enum CustomizablePart {
    Status, Hair, OutWear, Pants, Shoes
}

public class Customization {

    public int index;
    public CustomizablePart part;

    public Customization(int index, CustomizablePart part) {
        this.index = index;
        this.part = part;
    }

}