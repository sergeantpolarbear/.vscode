-- Author: Nameous Changey
-- GitHub: https://github.com/nameouschangey/STORMWORKS_VSCodeExtension
-- Workshop: https://steamcommunity.com/id/Bilkokuya/myworkshopfiles/?appid=573090
--- Developed using LifeBoatAPI - Stormworks Lua plugin for VSCode - https://code.visualstudio.com/download (search "Stormworks Lua with LifeboatAPI" extension)
--- If you have any issues, please report them here: https://github.com/nameouschangey/STORMWORKS_VSCodeExtension/issues - by Nameous Changey

require("LifeBoatAPI.Tools.Utils.Base")
require("LifeBoatAPI.Tools.Utils.TableUtils")
require("LifeBoatAPI.Tools.Utils.StringUtils")

---@class StringReplacer : BaseClass
---@field renamer VariableRenamer
---@field stringsReplaced table<string,table>
LifeBoatAPI.Tools.StringReplacer = {

    ---@return StringReplacer
    new = function(cls, renamer)
        local this = LifeBoatAPI.Tools.BaseClass.new(cls)
        this.stringsReplaced = {}
        this.count = 1
        this.renamer = renamer
        return this
    end;

    ---@param this StringReplacer
    ---@param stringValue string value to replace with a constant, including the surrounding quotes
    ---@return string replacement constant
    getStringReplacement = function(this, stringValue)
        if(not this.stringsReplaced[stringValue]) then
            this.count = this.count + 1
            local replacement = string.format("STRING%07dREPLACEMENT", this.count)
            this.stringsReplaced[stringValue] = {value = replacement, count = 1}
            return replacement
        else
            this.stringsReplaced[stringValue].count = this.stringsReplaced[stringValue].count + 1
            return this.stringsReplaced[stringValue].value
        end
    end;

    ---@param this StringReplacer
    ---@param text string text that was previously stripped of strings
    ---@return string text with original strings repopulated
    repopuplateStrings = function(this, text, shortenStringDuplicates)
        for k,v in pairs(this.stringsReplaced) do
            local count = LifeBoatAPI.Tools.StringUtils.count(text, LifeBoatAPI.Tools.StringUtils.escape(v.value))
            if shortenStringDuplicates and count > 1 then
                -- if there's multiples of this string constant, we're almost always better to create a new variable for it
                local newName = this.renamer:getShortName()
                text = newName .. "=" .. k .. "\n" .. text:gsub(v.value, LifeBoatAPI.Tools.StringUtils.escapeSub(newName))
            else
                -- direct sub if there's only 1 of the string
                text  = text:gsub(v.value, LifeBoatAPI.Tools.StringUtils.escapeSub(k))
            end
        end
        return text
    end;
};

LifeBoatAPI.Tools.Class(LifeBoatAPI.Tools.StringReplacer);

