﻿using FluentAssertions;
using FsCheck;
using FsCheck.Xunit;

namespace MarsRover;

/// <summary>
/// This is where you can describe new properties for the Rover.
///
/// Link to FsCheck documentation: https://fscheck.github.io/FsCheck/
/// </summary>
public class RoverProperties
{
    [Property] //Note we use a special PropertyAttribute
    public void example_property_assertion(Rover r, Command c) => //All input arguments you declare for your properties will be randomly generated by the testing framework.
        r.Execute(c).Should().Be(r, "FIXME"); //you can use assertions in a property
    /*
    Example output of a failing property:

    FsCheck.Xunit.PropertyFailedException

    Falsifiable, after 1 test (0 shrinks) (StdGen (117936488,297098571)):
    Original:
    (Rover { Direction = E, Location = Location { X = 0, Y = 0 } }, F)
    */

    [Property]
    public Property example_property_predicate(Rover r) => //You can also have your Property methods return a property
        (r == null).ToProperty(); //ToProperty wraps any true/false predicate into a property

}