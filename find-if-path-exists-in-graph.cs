public class Solution 
{
	    public bool ValidPath(int n, int[][] edges, int source, int destination) 
		        {
				        UnionFind  uf = new UnionFind(n);
					        foreach(var edge in edges)
							        {
									            uf.Union(edge[0], edge[1]);
										            }

						        return uf.Find(source) == uf.Find(destination);
							    }

	        class UnionFind
			    {
				            private readonly int[] _root;
					            private readonly int[] _rank;

						            public UnionFind(int n)
								            {
										                _root = new int[n];
												            _rank = new int[n];
													                for(int i = 0; i < n; i++)
																            {
																		                    _root[i] = i;
																				                    _rank[i] = 1;
																						                }
															        }

							            public int Find(int x)
									            {
											                if(_root[x] != x)
														            {
																                    _root[x] = Find(_root[x]);
																		                }
													            return _root[x];
														            }

								            public void Union(int x, int y)
										            {
												                int rootX = Find(x);
														            int rootY = Find(y);

															                if(rootX != rootY)
																		            {
																				                    if(_rank[rootX] > _rank[rootY])
																							                    {
																										                        var tmp = rootX;
																													                    rootX = rootY;
																															                        rootY = tmp;
																																		                }

																						                    _root[rootX] = rootY;
																								                    _rank[rootY] += _rank[rootX];
																										                }
																	        }
									        }
}public class Solution 
{
	    public bool ValidPath(int n, int[][] edges, int source, int destination) 
		        {
				        UnionFind  uf = new UnionFind(n);
					        foreach(var edge in edges)
							        {
									            uf.Union(edge[0], edge[1]);
										            }

						        return uf.Find(source) == uf.Find(destination);
							    }

	        class UnionFind
			    {
				            private readonly int[] _root;
					            private readonly int[] _rank;

						            public UnionFind(int n)
								            {
										                _root = new int[n];
												            _rank = new int[n];
													                for(int i = 0; i < n; i++)
																            {
																		                    _root[i] = i;
																				                    _rank[i] = 1;
																						                }
															        }

							            public int Find(int x)
									            {
											                if(_root[x] != x)
														            {
																                    _root[x] = Find(_root[x]);
																		                }
													            return _root[x];
														            }

								            public void Union(int x, int y)
										            {
												                int rootX = Find(x);
														            int rootY = Find(y);

															                if(rootX != rootY)
																		            {
																				                    if(_rank[rootX] > _rank[rootY])
																							                    {
																										                        var tmp = rootX;
																													                    rootX = rootY;
																															                        rootY = tmp;
																																		                }

																						                    _root[rootX] = rootY;
																								                    _rank[rootY] += _rank[rootX];
																										                }
																	        }
									        }
}
