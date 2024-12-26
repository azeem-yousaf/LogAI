namespace LogAI.LLM.Interface.TrainingDataSet;

internal record TrainingData(string id, IEnumerable<TrainingDatum> trainingData);


internal record Metadata(string context);


internal record TrainingDatum(IEnumerable<Turn> turn);

internal record Turn(Metadata metadata, string inputText, string outputText);