class Reference
{
    private string referenceText;

    public Reference(string referenceText){
        this.referenceText = referenceText;
    }

    public string GetFullReference(){
        return referenceText;
    }
}
