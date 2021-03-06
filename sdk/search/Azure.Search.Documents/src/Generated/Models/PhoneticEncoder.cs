// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Identifies the type of phonetic encoder to use with a PhoneticTokenFilter. </summary>
    public enum PhoneticEncoder
    {
        /// <summary> Encodes a token into a Metaphone value. </summary>
        Metaphone,
        /// <summary> Encodes a token into a double metaphone value. </summary>
        DoubleMetaphone,
        /// <summary> Encodes a token into a Soundex value. </summary>
        Soundex,
        /// <summary> Encodes a token into a Refined Soundex value. </summary>
        RefinedSoundex,
        /// <summary> Encodes a token into a Caverphone 1.0 value. </summary>
        Caverphone1,
        /// <summary> Encodes a token into a Caverphone 2.0 value. </summary>
        Caverphone2,
        /// <summary> Encodes a token into a Cologne Phonetic value. </summary>
        Cologne,
        /// <summary> Encodes a token into a NYSIIS value. </summary>
        Nysiis,
        /// <summary> Encodes a token using the Kölner Phonetik algorithm. </summary>
        KoelnerPhonetik,
        /// <summary> Encodes a token using the Haase refinement of the Kölner Phonetik algorithm. </summary>
        HaasePhonetik,
        /// <summary> Encodes a token into a Beider-Morse value. </summary>
        BeiderMorse
    }
}
