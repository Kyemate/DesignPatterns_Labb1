using DesignPatterns_Labb1;
using DesignPatterns_Labb1.Interfaces;

/*
 * Projektet implementerar följande:
 * Factory pattern
 * Singleton pattern
 * Observer pattern
 * Strategy pattern
 *
 * Objekten är tydligt namngivna med vilket mönster dom implementerar.
 *
 */


var observer = ObserverFactory.CreateObserver();
var emitter = ObserverFactory.CreateObservable();
emitter.Subscribe(observer);


emitter.Emit("Halloj världen!");


