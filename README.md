# BinaryFormatter

BinaryFormatter is an Fast, Lightweight Binary serialization/deserialization library for Unity projects.

## Download

- [:sparkles: Download latest version](https://github.com/BayatGames/BinaryFormatter/releases/latest)
- [:fire: Download from Asset Store](https://www.assetstore.unity3d.com/#!/content/100459?aid=1101l3ncK)

## Features

- Serializing Collections: Lists, Dictionaries, IEnumerable
- Serializing KeyValuePair
- Serializing ISerializable
- Serializing Multi-Dimensional Arrays
- Surrogate Serialization
- Serializing Almost anything (Automatically serializes public fields and properties)
- Deserializing IDeserializationCallback
- Fast and Helpful Customer Support
- Free & Open Source
- Easy to Use
- Cross Platform (Let us know if you have any problem with any platform)

## Getting Started

Just add

```csharp
using BayatGames.Serialization.Formatters.Binary;
```

then you are ready to go.

BinaryFormatter provides some static methods for fast serialization of objects to binary:

```csharp
using BayatGames.Serialization.Formatters.Binary;
...
byte[] buffer = BinaryFormatter.SerializeObject ("Hello World");
```

## Resources

- [Unity Asset Store](https://www.assetstore.unity3d.com/en/#!/search/page=1/sortby=popularity/query=publisher:26641)
- [Support and News](https://github.com/BayatGames/Support)
- [Community Thread](https://forum.unity.com/threads/binaryformatter-complete-binary-serialization-library-for-unity.495707/)
- [:rocket: Patreon](https://www.patreon.com/BayatGames)

## License

MIT @ [Bayat Games](https://github.com/BayatGames)

Made with :heart: by [Bayat Games](https://github.com/BayatGames)
