public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        var graph = new Dictionary<string, List<string>>();
        var missingIngredients = new Dictionary<string, int>();

        var result = new List<string>();

        for(int i = 0; i < recipes.Length; i++) {
            string recipe = recipes[i];
            foreach (string ing in ingredients[i]) {
                if(!graph.ContainsKey(ing)) {
                    graph[ing] = new List<string>();
                }
                graph[ing].Add(recipe);

                if(!missingIngredients.ContainsKey(recipe)) {
                    missingIngredients[recipe] = 0;
                }
                missingIngredients[recipe]++;
            }
        }

       Queue<string> queue = new Queue<string>();
       
       foreach(string supply in supplies) {
            queue.Enqueue(supply);
        }

        while(queue.Count > 0) {
            var current = queue.Dequeue();
            
            if (!graph.ContainsKey(current)) continue;

            foreach (var dependentRecipe in graph[current]) {
                missingIngredients[dependentRecipe]--;

                if(missingIngredients[dependentRecipe] == 0) {
                    queue.Enqueue(dependentRecipe);
                    result.Add(dependentRecipe);
                }
            }

        }
        return result;
    }
}