# Text Adapters

## Observation
At some point in a project, multiple scripts need access to modify displayed text. But developers can choose from a range of available text components, e.g. Text, TextMeshProUGUI, CrispyText, etc. If all avaliable text components would implement the same inteface, it would be pretty simple to modify their content. Unfortunately they don't do that. Implementing different scripts, one for each available  type of text components, is the naive way to solve this problem. Instead, implementing adapters is the right way to solve the problem.

## Areas Of Application
- Tables with mutable content 
- <details open>
  <summary>Text Localization</summary>
  <br/>
  Important note: The information below needs to be reworked!

  ## Observation
  I have seen people attaching scripts for localization directly onto gameobjects, containing Unity's standard UI Text components,
  CrispyText components or TextMeshPro Text components. This can become very confusing depending on the amount of text inside scenes.

  Object nesting, especially within Canvas elements, can have a large impact on the implementation time. But how to avoid this problem? My favorite strategy is to outsource all scripts related to localization. It does not reduce the amount of nested objects within Canvas elements. But it centralizes all scripts affecting text components.

  ## Advantages
  + Flattening parts of the scene graph increases readability and refactorability. 
      + So obtaining an overview of all assigned IDs for localization becomes easier.
      + In addition finding unassigned IDs becomes clearer. 
  + Moreover it will introduce Loose Coupling between scripts for localization and UI elements.
      + This can become very powerful in combination with a good scene management system.
      + Ideally, scripts for localization can be outsourced to another scene.
      + Which would mean that team members can implement features more independently.
      + This means gaining more flexibility. Which also means less collisions and less merge conflicts.
      + So the major benefit is an increase in productivity.

  ## Disadvantages
  - Connections can break more easily.
  - Debugging can become harder for inexperienced developers.
  - Poorly conceived and unfinished solutions can introduce even more problems.

  ## Structure of custom scripts
  - Scripts could check if they are connected to UI elements. This could be done on application start or while still working in the Unity Editor.
  - If the type of the UI element is already known, custom scripts can be implemented which do not have to call methods like GetComponent().

  ## Optimization
  - While thinking about scene management, I came to the conclusion, that scripts must (un-)register themself to some kind of localization manager. That gave me the idea to implement the (Object) Adapter Pattern. Later on I came to the conclusion to separate the logic for (un-)registration and the logic to change displayed text depending on the selected language. But the Adapter pattern still exists.
</open>

## Implementation Details

![The image shows the benefit of using the adapter pattern for localization](https://github.com/essentialpackages/text-adapter/blob/master/resources/custom-adapter-pattern.png)

## Import Details

- .Net 4.x is enabled in Player Settings even if it is not used at the moment
- The package uses Assembly Files. If you don't use assemblies, you should not import them into your existing projects.
- The package uses TextMesh Pro. If you haven't imported TextMesh Pro yet, compilation errors will occure, because some namespaces
cannot be found. To fix that problem, you must remove the TextMesh Pro reference in all assembly files and remove TextMeshProUguiAdapter.cs.
  <details open>
  1.) Select the assembly in the project window.
  
  ![Project Window](https://github.com/essentialpackages/text-adapter/blob/master/resources/ProjectWindow.png)
  2.) Remove the TextMesh Pro reference.
  
  ![Inspector Window](https://github.com/essentialpackages/text-adapter/blob/master/resources/Inspector.png)
  
  3.) Remove TextMeshProUguiAdapter.cs
  </details>

