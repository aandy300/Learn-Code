<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInit2889c79381e732a8c2f929b90cb7c6ec
{
    public static $files = array (
        '3917c79c5052b270641b5a200963dbc2' => __DIR__ . '/..' . '/kint-php/kint/init.php',
    );

    public static $prefixLengthsPsr4 = array (
        'K' => 
        array (
            'Kint\\' => 5,
        ),
    );

    public static $prefixDirsPsr4 = array (
        'Kint\\' => 
        array (
            0 => __DIR__ . '/..' . '/kint-php/kint/src',
        ),
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->prefixLengthsPsr4 = ComposerStaticInit2889c79381e732a8c2f929b90cb7c6ec::$prefixLengthsPsr4;
            $loader->prefixDirsPsr4 = ComposerStaticInit2889c79381e732a8c2f929b90cb7c6ec::$prefixDirsPsr4;

        }, null, ClassLoader::class);
    }
}
