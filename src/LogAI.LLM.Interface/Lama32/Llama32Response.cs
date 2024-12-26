namespace LogAI.LLM.Interface.Lama32;

internal struct Llama32Response
{
    public string model { get; set; }
    public DateTime created_at { get; set; }
    public string response { get; set; }
    public bool done { get; set; }
    public string done_reason { get; set; }
    public List<int> context { get; set; }
    public int total_duration { get; set; }
    public int load_duration { get; set; }
    public int prompt_eval_count { get; set; }
    public int prompt_eval_duration { get; set; }
    public int eval_count { get; set; }
    public int eval_duration { get; set; }
}