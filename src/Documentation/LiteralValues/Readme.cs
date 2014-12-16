﻿/**
# Documentation

## Working with literal values

As always, here are the required namespace imports.
**/

using System;
using System.Net;
using JsonLD.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

/**
### Deserialize expanded form of literals

JSON-LD have two ways of explicitly representing typed literal. They can be typed in the `@context`, in which case the JSON property value is
a simple string token.

``` js
{
  "@context": {
    "age": {
      "@id": "http://example.com/onto#age",
      "@type": "http://www.w3.org/2001/XMLSchema#integer"  
    }
  },
  "age": "28"
}
```

The other way is to directly state the value's type by expanding the literal to JSON object. See how the `@type` is moved from the 
`@context` and a `@value` keyword is introduced.

``` js
{
  "@context": {
    "age": {
      "@id": "http://example.com/onto#age"
    }
  },
  "age": {
    "@value": "28",
    "@type": "http://www.w3.org/2001/XMLSchema#integer"
  }
}
```

The two examples above may be equivalent but the second one, which you will probably commonly encounter when working with JSON-LD, poses a
problem for default Newtonsoft.Json serializer, because JSON object is not expected for primitive type such as `int` or `bool`.
**/

[TestFixture]
public class DeserializationOfLiterals
{

/**
JsonLd.Entities will try to deserialize the `@value` instead. Note however that if the actual type and C# property types don't match a
round trip deserialization and serialization could produce different JSON-LD.
**/

public class PersonWithAge
{
    public Uri Id { get; set; }

    public long Age { get; set; }
}

[Test]
public void Can_deserialize_expanded_literal()
{
    // given
    var jsonLd = JObject.Parse(@"
{
  '@context': {
    'age': {
      '@id': 'http://example.com/onto#age'
    }
  },
  'age': {
    '@value': '28',
    '@type': 'http://www.w3.org/2001/XMLSchema#integer'
  }
}");

    // when
    IEntitySerializer serializer = new EntitySerializer(new StaticContextProvider());
    var person = serializer.Deserialize<PersonWithAge>(jsonLd);

    // then
    Assert.That(person.Age, Is.EqualTo(28));
}

/**
### Using custom converter to serialize class instance as literal

Of course if is also possible to use Newtonsoft.Json's attributes to define custom converter for a property. For example we may want to use
a custom converter to convert `IPAddress` to string values.
**/

public class RequestLogItem
{
    [JsonConverter(typeof(IPAddressConverter))]
    public IPAddress Ip { get; set; }   
}

[Test]
public void Can_deserialize_class_from_literal()
{
    // given
    var jsonLd = JObject.Parse(@"
{
  '@context': {
    'ip': {
      '@id': 'http://rdfs.org/sioc/ns#ip_address'
    }
  },
  'ip': '148.9.20.34'
}");

    // when
    IEntitySerializer serializer = new EntitySerializer(new StaticContextProvider());
    var person = serializer.Deserialize<RequestLogItem>(jsonLd);

    // then
    Assert.That(person.Ip, Is.EqualTo(IPAddress.Parse("148.9.20.34")));
}

/**
And it would also work if the literal was given in it's expanded form.
**/

[Test]
public void Can_deserialize_class_from_expanded_literal()
{
    // given
    var jsonLd = JObject.Parse(@"
{
  '@context': {
    'ip': {
      '@id': 'http://rdfs.org/sioc/ns#ip_address'
    }
  },
  'ip': { '@value': '148.9.20.34' }
}");

    // when
    IEntitySerializer serializer = new EntitySerializer(new StaticContextProvider());
    var person = serializer.Deserialize<RequestLogItem>(jsonLd);

    // then
    Assert.That(person.Ip, Is.EqualTo(IPAddress.Parse("148.9.20.34")));
}
}