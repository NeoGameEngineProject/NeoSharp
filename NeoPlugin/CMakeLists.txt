## Find source and headers
FILE(GLOB HEADERS *.h)
FILE(GLOB SOURCES *.c*)

IF(CMAKE_HAS_SORT)
  LIST(SORT HEADERS)
  LIST(SORT SOURCES)
ENDIF(CMAKE_HAS_SORT)

## Build
INCLUDE_DIRECTORIES(
  ${NEO_INCLUDES}
  ${MONO_INCLUDES}
)

ADD_LIBRARY(Game SHARED ${SOURCES} ../Swig/swig_wrap.cxx ${HEADERS})
TARGET_LINK_LIBRARIES(Game ${NEO_LIBRARIES} ${MONO_LIBRARIES})
