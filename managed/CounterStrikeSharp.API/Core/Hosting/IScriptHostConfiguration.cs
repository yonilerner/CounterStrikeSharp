﻿namespace CounterStrikeSharp.API.Core.Hosting;


/// <summary>
/// Provides information about the hosting environment an application is running in.
/// </summary>
public interface IScriptHostConfiguration
{
    /// <summary>
    /// Gets the absolute path to the directory that contains all CounterStrikeSharp files.
    /// e.g. /game/csgo/addons/counterstrikesharp
    /// </summary>
    string RootPath { get; }
    
    /// <summary>
    /// Gets the absolute path to the directory that contains all CounterStrikeSharp plugins.
    /// e.g. /game/csgo/addons/counterstrikesharp/plugins
    /// </summary>
    string PluginPath { get; }
    
    /// <summary>
    /// Gets the absolute path to the directory that contains all CounterStrikeSharp configs.
    /// e.g. /game/csgo/addons/counterstrikesharp/configs
    /// </summary>
    string ConfigsPath { get; }
    
    /// <summary>
    /// Gets the absolute path to the directory that contains all CounterStrikeSharp game data.
    /// e.g. /game/csgo/addons/counterstrikesharp/gamedata
    /// </summary>
    string GameDataPath { get; }
}