namespace Project2B
{
    //Algorithm does DFS and allows to explore terrain until all the terrain is explored.
    internal class Algorithm1 : IExploreAlgorithm
    {
        

        public void Explore(IActor player, ILocations locations, Control flag)
        {

            if (flag.Flag == true)
            {
                var j = locations.GetEnumerator();



                var t = ((ILocationDecorator) locations).GetPlayerMarker(player);


                if (locations as IExit != null && flag.Flag == true)
                {
                   

                    locations.EnterLocation(player);
                     locations.ExitLocation(player);
                    flag.Flag = false;

                    //if ((flag.Count > 0 && t == null))
                   // {
                       // locations.EnterLocation(player);
                       // locations.ExitLocation(player);
                       // var i = flag.Count;
                       // flag.Count = (i - 1);
                       // return;
                        /*

                        while (j.MoveNext())
                        {
                            if (j.Current != null)
                            {
                                if (((LocationDecorator) j.Current).GetPlayerMarker(player) != null)
                                {
                                    if (!((LocationDecorator) j.Current).GetPlayerMarker(player).Equals(Marker._red))
                                    {
                                        Explore(player, j.Current as ILocations, flag);
                                    }

                                }
                                else if (((LocationDecorator) j.Current).GetPlayerMarker(player) == null)
                                {
                                    Explore(player, j.Current as ILocations, flag);

                                }
                            }
                        */
                    }








                  //  if (t != null && flag.Count < 1)
                   // {
                        //locations.EnterLocation(player);
                       // locations.ExitLocation(player);
                       // flag.Flag = false;
                       // return;


                        /*
                            while (j.MoveNext())
                            {
                                if (j.Current != null)
                                {
                                    if (((LocationDecorator) j.Current).GetPlayerMarker(player) != null)
                                    {
                                        if (!((LocationDecorator) j.Current).GetPlayerMarker(player).Equals(Marker._red))
                                        {
                                            Explore(player, j.Current as ILocations, count, flag);
                                        }

                                    }
                                    else if (((LocationDecorator) j.Current).GetPlayerMarker(player) == null)
                                    {
                                        Explore(player, j.Current as ILocations, count, flag);

                                    }
                                }

                            }
                            */
                   // }

               // }




                if (t == null && flag.Flag == true)
                {

                       goto Loop;


                }
                else if (((ILocationDecorator) locations).GetPlayerMarker(player).Equals(Marker._green) &&
                         flag.Flag == true)
                {
                     goto Loop;


                }

               //Goto comes here
               Loop:
                
                locations.EnterLocation(player);
                locations.ExitLocation(player);
                
                while (j.MoveNext())
                {
                    if (j.Current != null)
                    {
                        if (((ILocationDecorator)j.Current).GetPlayerMarker(player) != null)
                        {
                            if (((ILocationDecorator)j.Current).GetPlayerMarker(player).Equals(Marker._green))
                            {
                                Explore(player, j.Current as ILocations, flag);
                            }
                        }
                        else if (((ILocationDecorator)j.Current).GetPlayerMarker(player) == null)
                        {
                            Explore(player, j.Current as ILocations, flag);
                        }
                    }

                }



                return;

            }
            
        }

    }

}






